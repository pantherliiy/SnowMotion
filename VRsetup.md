# VR Setup for Unity 2020.2.7f1

Used tutorial written at "https://www.reddit.com/r/Unity3D/comments/kno23d/unity_202021f1_setting_up_unity_with_the_oculus/". Shows how to add control for Oculus Quest 2. Note that Unity version 2020 apparently uses different methods for integrating the oculus quest into Unity. For example the XR plugin is used for 2019.x.x versions. In case of errors, it may be nessecary to remove the oculus files. 


## Taken from the reddit post above
(UNITY 2020.2.1f1)

The intention of this post is to show you how to set it up to work, since this was a problem I had in the past.

These are the steps you need to follow in order, for beeing able to use Unity editor "play" button with you Oculus Quest 2 in real time (and it will also allow you to build projects if you want to do it as well):

1. Make sure you have an Oculus Link cable. If you don't have one you can buy it through the oficial Oculus web page or Amazon. You don't need to buy the oficial Oculus link cable, any other third party Link cable for Oculus works. I recommend you a lenght of at least 5m.

2. Make sure you have the latest updates installed in your Oculus Quest 2.

3. Donwload the Oculus software in your PC. If you already have it, make sure you have the last update.

4. Make sure the Oculus desktop app is running. Connect your Oculus Quest 2 to your PC using your Oculus link cable (it is best if you use an USB port 3.0 or 3.1).

5. On your Oculus, you will see a message asking you if you allow the connected device to access your files, click "Allow". Then, it will ask you if you want to start Oculus link, click "Yes".

6. Your Oculus Quest 2 setup is ready. Now go to Unity and create a new empty 3D project.

7. First, switch in the build settings to Android and make sure you have selected as texture compression ASTC and as run device you have selected your Oculus Quest 2.

8. Now, go to the package manager and in the packages from the Unity Registry, install the XR plugin management.

9. Once the XR plugin management is installed, you will need to get from the Asset Store the "Oculus integration" asset. Once you get this asset, install it in your project. You just need to add the VR folder and the platform folder. The rest of the folders are optional if you are not going to use the features like the Oculus Avatar or the Lipsync libary.

10. In your project, go to Project settings > XR Plug-in management. Go to the Android Icon and make sure that Initialize XR plugin on Startup is marked as true and in plugins provider make sure you have Oculus selected.

11. In your project, go to Project settings > XR Plug-in management. Go to the Windows Icon and make sure that Initialize XR plugin on Startup is marked as true and in plugins provider make sure you have Oculus selected. This can be not so trivial to understand at first, because the Oculus Quest 2 use Android. This is beeing done so that the Unity "Play" button works, since the Oculus Quest 2 detects the Unity editor "Play" button as a Rift S app, and those are built through Windows.

12. Go to Project settings > Player > Android > Other settings. Make sure that Color space is set to Linear. Uncheck Auto Graphics API. Make sure in the Graphics API the top one is OpenGLES3. Make sure you have Multithreaded Rendering is enabled. Make sure your minimun API level is Android 6.0 Marshmallow (API level 23) since this is the minimun level supported by the Oculus Quest 2 nowadays.


Finally create an empty demo scene to test that everything is working, where you have a directional light, an OVRPlayerController (included in the Oculus folder from the Oculus integration asset) and a floor where the OVRPlayerController is standing on.

You are now good to go. If you followed this steps in order you should now be able to click play in the Unity editor and see it working in your Oculus Quest 2 in real time.

Also if you now click "Build and run" you should be able to test your project directly in your Oculus Quest 2.


# VR Setup for Unity 2019.x.xfx
For this, one can use the XR plugin. Have however not tried this. Just note that using the oculus integration asset for this may cause errors, and wont possibly work (maybe with a lot of debugging).



# Debbung, VR or Boundry not found
Follow the steps down in this thread: https://forum.unity.com/threads/oculus-integration-pack-problem-with-unity-2020-2.1028716/
Need to remove some files and reimport Oculus Integration after restaring Unity project.
Remember to check that the settings from the guide above are still true after reset.

