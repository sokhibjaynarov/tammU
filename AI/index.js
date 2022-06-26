var secondsToWait = 5 * 1000; //5 seconds
var modelsA = [];
var modelsB = [];

const classifier = knnClassifier.create();
const webcamElement = document.getElementById("webcam");
let net;

var audio = new Audio("audio_file.mp3");
var secondsToSignal = -1;
async function app() {
  console.log("Loading mobilenet..");

  // Load the model.
  net = await mobilenet.load();
  console.log("Sucessfully loaded model");

  await setupWebcam();
  // Reads an image from the webcam and associates it with a specific class
  // index.
  const addExample = classId => {
    // Get the intermediate activation of MobileNet 'conv_preds' and pass that
    // to the KNN classifier.
    const activation = net.infer(webcamElement, "conv_preds");
    
    if(classId == 0) modelsA.push(activation);
    if(classId == 1) modelsB.push(activation);

    localStorage.setItem('modelsA', JSON.stringify(modelsA));
    localStorage.setItem('modelsB', JSON.stringify(modelsB));


    // Pass the intermediate activation to the classifier.
    classifier.addExample(activation, classId);
  };

  const addExampleFromLocal = (classId, activation) => {
    // Get the intermediate activation of MobileNet 'conv_preds' and pass that
    // to the KNN classifier.
    // const activation = net.infer(webcamElement, "conv_preds");
    if(classId == 0) modelsA.push(activation);
    if(classId == 1) modelsB.push(activation);

    // localStorage.setItem('modelsA', JSON.stringify(modelsA));
    // localStorage.setItem('modelsB', JSON.stringify(modelsB));


    // Pass the intermediate activation to the classifier.
    classifier.addExample(activation, classId);
  };
  const getLocalModels = () => {
    console.log("Fetching local models");
    var modelsA = JSON.parse(localStorage.getItem('modelsA'));
    var modelsB = JSON.parse(localStorage.getItem('modelsB'));
    if(modelsA && modelsB){
      modelsA.forEach(element => {
        addExampleFromLocal(0, element);
      });
      modelsB.forEach(element => {
        addExampleFromLocal(1, element);
      });
    }
    
  }
  // getLocalModels();

  // When clicking a button, add an example for that class.
  document
    .getElementById("class-a")
    .addEventListener("click", () => addExample(0));
  document
    .getElementById("class-b")
    .addEventListener("click", () => addExample(1));

  while (true) {
    if (classifier.getNumClasses() > 0) {
      // Get the activation from mobilenet from the webcam.
      const activation = net.infer(webcamElement, "conv_preds");
      // Get the most likely class and confidences from the classifier module.
      const result = await classifier.predictClass(activation);

      const classes = ["A", "B"];
      if (classes[result.classIndex] == "B") {
        if (secondsToSignal == -1) {
          //set seconds
          secondsToSignal = parseInt(+new Date()) + secondsToWait;
          // console.log(secondsToSignal);
        }
        if (secondsToSignal != -1 && secondsToSignal < parseInt(+new Date())) {
          // console.log(parseInt(secondsToSignal)  < parseInt(+new Date()));
          await audio.play();
          document.body.style.backgroundColor = "rgb(168, 63, 63)";
        }
      } else {
        secondsToSignal = -1;
        document.body.style.backgroundColor = "rgb(80, 168, 80)";
      }
    }

    await tf.nextFrame();
  }
}

async function setupWebcam() {
  return new Promise((resolve, reject) => {
    const navigatorAny = navigator;


    navigator.getUserMedia =
      navigator.getUserMedia ||
      navigatorAny.webkitGetUserMedia ||
      navigatorAny.mozGetUserMedia ||
      navigatorAny.msGetUserMedia;
    if (navigator.getUserMedia) {
      navigator.getUserMedia(
        { video: true },
        stream => {
          webcamElement.srcObject = stream;
          webcamElement.addEventListener("loadeddata", () => resolve(), false);
        },
        error => reject()
      );
    } else {
      reject();
    }
  });
}



app();
