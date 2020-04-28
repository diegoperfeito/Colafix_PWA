'use strict';

var videoElement = document.querySelector('video');
var videoSelect = document.querySelector('select#videoSource');

navigator.mediaDevices.enumerateDevices().then(gotDevices).then(getStream).catch(handleError);

videoSelect.onchange = getStream;

function gotDevices(deviceInfos) {
    var videDevice = 0;
    for (var i = 0; i !== deviceInfos.length; ++i) {
        var deviceInfo = deviceInfos[i];
        var option = document.createElement('option');
        option.value = deviceInfo.deviceId;
        if (deviceInfo.kind === 'videoinput') {
            if (videDevice === 0) {
                option.text = 'Frontal';
            }
            else if (videDevice === 1) {
                option.text = 'Traseira';
            }

            else {
                option.text = 'Camera '.concat(videoSelect.length + 1);
            }
            videDevice++;
            videoSelect.appendChild(option);
        }
    }
}

function getStream() {
    if (window.stream) {
        window.stream.getTracks().forEach(function (track) {
            track.stop();
        });
    }

    var constraints = {
        video: {
            deviceId: { exact: videoSelect.value }
        }
    };

    navigator.mediaDevices.getUserMedia(constraints).
        then(gotStream).catch(handleError);
}

function gotStream(stream) {
    window.stream = stream; // make stream available to console
    videoElement.srcObject = stream;
}

function handleError(error) {
    console.log('Error: ', error);
}