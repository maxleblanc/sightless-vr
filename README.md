<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/github_username/repo_name">
    <img src="https://user-images.githubusercontent.com/10538039/186792225-550e8df7-df9a-42ec-a25d-6d952927e11b.jpg" alt="Logo" width="280" height="280">
  </a>
  </div>

<h3 align="center">Sightless VR</h3>

<p align="center">
Way-finding through virtual spaces using haptics and VR tracking. </br>
Completed on Dec. 2019
<div align="center">
  



<div align="center">

 [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

 </div>

  ![Unity](https://img.shields.io/badge/unity-%23000000.svg?style=for-the-badge&logo=unity&logoColor=white)
  ![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
  ![C++](https://img.shields.io/badge/C%2B%2B-f34b7d?style=for-the-badge&logo=C%2B%2B&logoColor=white)
  ![Rhino 3D](https://img.shields.io/badge/Rhino_3D-lightgrey?style=for-the-badge&logo=Rhinoceros)
  ![Grasshopper](https://img.shields.io/badge/Grasshopper-green?style=for-the-badge&logo=Rhinoceros)
  ![Arduino](https://img.shields.io/badge/Arduino-00979D?style=for-the-badge&logo=Arduino&logoColor=white)

</div>


<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>

  - [About The Project](#about-the-project)
    * [More Concepts](#more-concepts)
    * [TL;DR](#tl-dr)
  - [The Site](#the-site)
    * [The Device](#the-device)
      + [System Boundary](#system-boundary)
  - [Photos of Testing and Prototyping](#photos-of-testing-and-prototyping)
  - [Experiment 1](#experiment-1)
    * [Experiment 1: User 1](#experiment-1--user-1)
    * [Experiment 1: User 2](#experiment-1--user-2)
    * [Experiment 1: User 3](#experiment-1--user-3)
  - [Experiment 2](#experiment-2)
  - [Results](#results)
  - [Resources Used](#resources-used)

</details>


<!-- ABOUT THE PROJECT -->
## About The Project

Technological innovations in the way of virtual environments accessible via head-mounted displays (HMD), haptic controllers, gloves, and wearables are offering new possibilities for spatial design and mobility. Commercial virtual reality (VR) hardware has historically been conspicuously cephalo-centric. HMDs are trademarks of a common picture associated with current VR. The wearer, as if blindfolded, stops seeing the “real” world around them and is transported into their individual, virtual, immersive “bubble.” From the outside, the bubble seems impermeable, closed, and inaccessible. From the inside, the bubble feels limitless, expansive, and ubiquitous. Contemporary common conceptions of VR picture the technology as a closed immersive bubbles separated from the “real” physical space. However, this conception is not entirely accurate. VR takes place. It is constructed through, and can be broken by, physical space. Using VR systems, partitions and obstacles existing in the digital realm (and bound to physical space) can be manifested through haptic pulses rendering them physical to the user. I argue that this ghostly architecture represents a shift in the way that architecture can interact with end-users.

Aspiring to critique the closed-world attitude toward VR, this research takes on the form of a critical design project (situated on the fifth floor of the Macdonald-Harrington building on the McGill University campus) that translates virtual obstacles into architectures in the physical world; making the virtual environment become part of the physical environment. Superimposing every floor of the Macdonald-Harrington building one on-top of another generates a site with non-arbitrary partition placement. These partitions, walls, and doorways found on lower floors are superimposed on the fifth floor space and are converted into virtual equivalents equipped with haptic feedback.

Ultimately, this thesis project is about developing a system of relationships between the user, the virtual environment and the physical environment as a way to generate questions pertaining to the concept of ghostly architecture and the interplay between virtual and physical space. Through the use of haptic feedback displays, I generated situations which challenge notions of wayfinding and spatial awareness. By skewing and distorting perceptions of space through virtual augmentation, I hope to frame questions surrounding VR (specifically sightless VR) and its uses/limits within physical reality.

### More Concepts

<details>
  <summary>Bursting the Bubble (click arrow to expand)</summary>
<p>

Contemporary conceptions of VR portray the technology a hermetic system in which a user becomes immersed in the simulation, when in actuality, virtual environments are intrinsically dependent on the physical world. VR exists within architecture. It relies on tangible metrics and spatial properties of physical boundaries in which it is contained. As such, VR is architectural by nature. VR takes place. It is constructed through, and can be broken by, physical space. Current generation VR systems such as the HTC Vive use optical tracking to enable room-scale geo-localization of a user within space. The physical boundary in which VR technology is contained is just as much a part of the process of world-making as the hardware itself.

To prevent the bubble from bursting, VR systems often encourage the removal on any potential obstacle which might interfere with the simulation. The outside world is seen as undesirable or antagonistic to the VR illusion.


<img src="https://user-images.githubusercontent.com/10538039/186797904-33f99587-af4a-441d-ad9f-39cfede31b08.gif" alt="Vive Setup Screen">
<p>

_Here for example, we see the setup screen for the HTC Vive VR system which asks users to move all objects out of the tracking space._

</details>

<details>
  <summary>Ghostly Architecture (click arrow to expand)</summary>
<p>

Superimposed or ghostly architecture can bring change to the current mode of operation commonly associated with VR and its bubble-centric ideology. By incorporating various layers of ghostly architectural elements, spaces become extended and augmented. Part of this project involves imagining the implication of the ghost in an architectural setting. Ghosts, in this case refers to architectural elements in the form of virtual objects superimposed on physical spaces.

Is the ghostly presence complimentary or opposite to the physical world? How does the boundary of these virtual elements map how a user moves within space? VR has the power to make tangible what one imagines or remembers, as well as bring forth an unexpected reality. In a way, it validates what one thinks and can manifest different versions of existence. The virtual-world slash physical-world duality is bound by rules, and playing with these rules can make for unexpected results.

</details>

### TL;DR

I created a haptic device allowing users to navigate a virtual room overlayed onto a physical room without the need for head-mounted displays.

![haptic device](https://user-images.githubusercontent.com/10538039/186795411-508c16b7-bbf6-4091-bfad-5820633f40cd.png)


<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- GETTING STARTED -->
## The Site

The focus of this critical design project was to create a large-scale experiment on the fifth floor of the Macdonald-Harrington building on the McGill University campus that challenges conventional uses of VR systems and generate questions pertaining to the use of haptic feedback in movement and space-making. I started by superimposing every floor one on-top of another to generate a sort of _reverse axonometric projection_. Instead of exploding level into specific layers, I collapsed and flattened the building into one plan. Now partitions, walls and doorways found on lower floors are superimposed on the fifth floor space and are converted into virtual equivalents equipped with haptic feedback.

![project site](https://user-images.githubusercontent.com/10538039/186800346-d88a6c25-b356-4679-bce0-d32afeb3e606.jpeg)

Architectural elements, real and virtual, now co-exist on a single floor. For the purposes of simplification, I decided to focus on making tangible basic architectural elements such as walls, windows, doors and columns of lower floors through haptic feedback. The user will experience haptic feedback through a haptic device mounted on the wrist and hand.

![virtual walls](https://user-images.githubusercontent.com/10538039/186801611-d3452f15-8ed1-4f8c-8baf-738d5983395d.gif)

The following step was to create a tool for navigating through my ghostly installation. Placement, intensity, frequency, and duration of the haptic events were evaluated in order to create a tool which enhances the experience. Ultimately, a user will be expected to navigate through the fifth floor exhibition room without a HMD. Using only a custom haptic device, they would sense the presence of architectural elements found on lower storeys. Although the partitions are virtual and invisible to the user, the sensations produced by way of haptic feedback make them visceral and real.

![wall vibration](https://user-images.githubusercontent.com/10538039/186802608-366616ca-e4df-4750-bef9-d115a1ed0cd6.gif)

![glitch wall aesthetics](https://user-images.githubusercontent.com/10538039/186803383-6c3bdf0f-af1c-4af5-bd2a-4efa8ff8e0b9.gif)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

### The Device

This project involved developing a haptic device capable of receiving wireless signals from the simulated world and creating a haptic pulse as a response to the contact with a virtual partition. The artefact had to be:

- portable and comfortably worn on the wrist and hand,
- wireless (as in untethered from the computer)
- able to vibrate for proper feedback to occur
- light and flexible to accommodate various hand/finger sizes and the finger’s normal range of motion


![sketch](https://user-images.githubusercontent.com/10538039/186974130-30ad21df-fe59-41cb-ae2f-daed9dc060fe.jpg) | ![sketch2](https://user-images.githubusercontent.com/10538039/186974618-66c5d521-8dcb-4183-a7f8-e583783788d2.jpg)
:-------------------------:|:-------------------------:

#### System Boundary

The communication between the simulated world and the user is done through an [Arduino Uno microcontroller](https://docs.arduino.cc/hardware/uno-rev3).

![schematics_2](https://user-images.githubusercontent.com/10538039/186977213-061fb00d-ac74-45b8-ae79-5709ec5f8725.jpg)

The following images show system diagrams which summarizes the flow of information from the tracked user to the [vibrating coin motor](https://a.co/d/iFumcX8) built into a flexible finger brace.

Below we can see a systems diagram which summarizes the flow of information from the tracked user to the vibrating coin motor. It begins with the virtual reality side of things. A tracking device sends geospatial information to the sensors, which in-turn compute the data. I am using Unity to generate the virtual partitions.

![schematics_1](https://user-images.githubusercontent.com/10538039/186977633-2ae83d9c-bbed-4e12-8937-e8c0e5715469.jpg)

The computer also controls the Transmitting Arduino board. The transmitting board’s job is to wait for the tracked user to collide with a virtual partition and then send a signal to the Receiving board using [nRF24L01+ wireless radio modules](https://nrf24.github.io/RF24/).

![schematics_4](https://user-images.githubusercontent.com/10538039/186977858-7f18b982-858a-4ef3-a894-23156549bbc8.jpg)

The receiving board, being completely untethered from the computer, is powered by an external battery pack. This allows the user to move freely in space without the burden of a cable. Once the signal is received, the Arduino activates the vibrating coin motor and this vibration is sensed through the flexible finger brace by the user.

![schematics_5](https://user-images.githubusercontent.com/10538039/186977969-4b6284a4-062d-4da3-b53a-d0883e9c3bfd.jpg)

The entire experiment relies on the Unity engine to process the user’s geospatial data and generate the virtual walls. Both Arduinos, as well as Unity, communicate to each-other via a custom C# code that I’ve written for each device.

![schematics_3](https://user-images.githubusercontent.com/10538039/186978558-e2268b0b-069d-4be3-bdc2-f82c49623fe3.jpg)

<p align="right">(<a href="#readme-top">back to top</a>)</p>


## Photos of Testing and Prototyping

<details>
  <summary>Prototyping (click arrow to expand)</summary>
<p>

![testing](https://user-images.githubusercontent.com/10538039/187000109-92b13784-3cc4-4c2b-bd8c-e94ae5cd9d4d.jpg)

![first-prototype](https://user-images.githubusercontent.com/10538039/186975551-dc273ca8-1fcc-41ec-b1bd-a43a7a6feb56.jpg)

![first-prototype2](https://user-images.githubusercontent.com/10538039/186975658-3947c4d6-14a5-4af5-8b16-10d565590ba1.jpg)

</details>

<details>
  <summary>Arduinos (click arrow to expand)</summary>
<p>

![arduino1](https://user-images.githubusercontent.com/10538039/187000114-c1d1d844-67e2-4e65-b911-a2cd00d7dfc2.jpg)

![arduino2](https://user-images.githubusercontent.com/10538039/187000118-314e6484-9b19-4ba2-b512-5a3d226402d8.jpg)

![arduino3](https://user-images.githubusercontent.com/10538039/187000125-204d7f1f-ff59-4214-a165-a92b34fa6084.jpg)

</details>

<details>
  <summary>Finger Brace 3D Printing (click arrow to expand)</summary>
<p>

![brace1](https://user-images.githubusercontent.com/10538039/187000129-d506ed62-cd5b-4878-b63c-9f54fd5e4871.jpg)

![brace2](https://user-images.githubusercontent.com/10538039/187000131-11c84eff-1c13-4b0a-b304-5e9b07f7fa5d.jpg)

</details>


<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Experiment 1

Using the first prototype, I filmed 2 users trying out the device. As part of the first test, once a user sensed a haptic pulse, they placed a marker on the floor. As the experiment unfolds, we begin to see the plan of the ghostly architecture reveal itself to us. The users here are the ones making the simulation visible. They act as renderers or even appendices for the simulated environment. The simulation requires the user to run, and the users require it to proceed.

### Experiment 1: User 1

<details>
  <summary>Video (click arrow to expand)</summary>
<p>

![Haptic_experiment_1](https://user-images.githubusercontent.com/10538039/187005261-5bb1ee8d-9fa9-4ab0-9106-11eb1352639a.gif)

</details>

### Experiment 1: User 2

<details>
  <summary>Video (click arrow to expand)</summary>
<p>

![Haptic_experiment_2](https://user-images.githubusercontent.com/10538039/187005264-843da584-14a9-4109-8b68-a47f726d961b.gif)

</details>

### Experiment 1: User 3

<details>
  <summary>Video (click arrow to expand)</summary>
<p>

![Haptic_experiment_3](https://user-images.githubusercontent.com/10538039/187005266-2a35e7f6-c070-4817-986b-c25763e11e01.gif)

</details>

<p align="right">(<a href="#readme-top">back to top</a>)</p>


## Experiment 2

In order to capture the results of these experiments as static images, I decided to use long-exposure photography which involves using a long-duration shutter speed to blur moving elements and obscure stationary ones. Long-exposure photography captures one thing that conventional photography does not: time.

I added two LEDs to the prototype: a continuously-lit red LED and a blinking blue LED. With the lights turned off, a camera set to long exposure mode will pick up these two light sources and create organic light trails. I chose to integrate a blinking LED in order to get a sense of velocity and acceleration and not just movement. The closer the blue trails are to one another, the slower the movement at that time. The more they are spaced out, the faster the movement.

![blinking_LEDs](https://user-images.githubusercontent.com/10538039/187005596-491509c6-5713-4e9b-98c9-934b26664aa3.gif)

Given the physical constraints of shooting long-exposure photography, I was limited to 25 second frames. Since the experiment lasted anywhere from 2-4min, I simply merged all the frames onto one another in post production to get the final light patterns.

![light_patterns_time](https://user-images.githubusercontent.com/10538039/187005763-279ce94b-31e5-480d-8005-e99665cc164c.png)

 The camera was setup in a top-view orientation and photographed the users performing the experiments. Once the lights were turned off, the LEDs mounted on the artefact would be picked up by the camera set in long-exposure mode.

 ![top-view](https://user-images.githubusercontent.com/10538039/187006067-8159fd11-e150-4e39-b3c8-c261019dd40c.gif)

 ![My Video](https://user-images.githubusercontent.com/10538039/187006168-37be8be5-5016-4183-a976-696c389cf4bc.gif)

 <p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- LICENSE -->
 ## Results

 Below are 2 experiments performed in the same location by 2 separate users with all frames overlaid on one another. We can note a few things here. Firstly, user 1 performed the experiment in 2min, while user 2 took almost 4min. This is represented in the intensity of the red trails (meaning that the movement was slower and therefore more light came into contact with the camera’s sensor). Also user 2 spent more time interacting with the virtual partition which is why we can see the layout of the ghostly plan more clearly. In white we can see the layout of the virtual partitions.

 ![](https://user-images.githubusercontent.com/10538039/187006294-b31d737f-19ca-4636-95dd-1b4a4621ea80.png)

 The tracking data provided by the HTC Vive Tracker puck installed on the wrist was also recorded during the experiment and mapped out in 3D using a custom Grasshopper script. The points were then assigned coordinates and could be processed further to create stylized digital artefacts.

 ![point_cloud_grasshopper](https://user-images.githubusercontent.com/10538039/187006716-1eefb017-10ae-465d-8d33-8745e7f6b6bb.gif)

 ![point_cloud](https://user-images.githubusercontent.com/10538039/187006943-7ad4f10e-4b64-40b9-bd25-d7130cf0884a.gif)


The above gif shows an axonometric 3D view of the tracked data. The scale of this artefact is about 3m by 3m. The virtual walls sensed by the user are represented as yellow planes, while the ground plane is in purple. The points in yellow are moments where the user felt a vibration when coming into contact with the virtual partitions. The points in red are moments when no vibration was felt.

The ultimate aim of this project was about making visible the system of relationships between the user, the virtual environment and the physical environment as a way to generate questions pertaining to the concept of ghostly architecture and the interplay between virtual and physical space.

<!-- ACKNOWLEDGMENTS -->
## Resources Used

- Unity's Uduino Plugin: https://assetstore.unity.com/packages/tools/input-management/uduino-arduino-communication-simple-fast-and-stable-78402
- Unity's SteamVR Plugin: https://assetstore.unity.com/packages/tools/integration/steamvr-plugin-32647
- nRF24L01 Documentation: https://nrf24.github.io/RF24/
- nRF24L01 Repo: https://github.com/nRF24/RF24
- Chen Jingcheng's Grasshopper ViveTrack Plugin: https://github.com/ccc159/ViveTrack
