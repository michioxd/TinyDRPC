# TinyDRPC

Tiny Discord Rich Presence Client, customize your "Playing" status, written in C# using [discord-rpc-csharp](https://github.com/Lachee/discord-rpc-csharp)

![image](https://github.com/michioxd/TinyDRPC/assets/80969068/82dc5d8b-ac5f-4b36-aa5a-1112aa946f40)

![image](https://github.com/michioxd/TinyDRPC/assets/80969068/5d1a8e6a-ae82-4a60-af05-3edc38e7b0ba)

## Features

- Top and bottom text
 
  ![image](https://github.com/michioxd/TinyDRPC/assets/80969068/e08b97ce-d0bd-411d-985a-59294b9b696f)

- Button (max 2)

  ![image](https://github.com/michioxd/TinyDRPC/assets/80969068/545bb26a-ea2e-4b15-b3c6-8ace2ee2403e)

- Large/small image

  ![image](https://github.com/michioxd/TinyDRPC/assets/80969068/c6c7f2be-929d-400b-b7cc-83f0472a0660)
 
- Minimize to tray icon

  ![image](https://github.com/michioxd/TinyDRPC/assets/80969068/a213c282-4092-456f-b494-7a17096df610)
  
- Run on startup
- Save running state for next startup

## Usage

- Download [setup from release page](https://github.com/michioxd/TinyDRPC/releases/latest).
- Install it then run it (or you can download portable version).
- Customize setting for your own.

## Tutorial

### How to custom "Playing \<your wanted name\>"

- Go to Configuration tab.
- Enter your Discord App ID (don't have?, [create one](#how-to-get-discord-app-id)).
- If daemon is running, stop it then start again.

### How to get Discord App ID

- Go to [Discord Developer Portal](https://discord.com/developers/applications).
- Click `New Application` (at top left, before your avatar).

  ![image](https://github.com/michioxd/discord-vugo/assets/80969068/db5ad43f-f64f-43fc-a06e-a1a4f67a2476)
  
- Enter a name you want.

  ![image](https://github.com/michioxd/discord-vugo/assets/80969068/8649070e-61f3-4618-93a6-321f08266442)

- You will be redirected to that application, scroll down to `APPLICATION ID`, copy it

  ![image](https://github.com/michioxd/TinyDRPC/assets/80969068/938e295c-4fbf-4c27-8c79-74bd1a5f27f3)

- That it!

### How to get Image key

- Go to [Discord Developer Portal](https://discord.com/developers/applications).
- Choose your application (make sure that application is the same with your App ID).
- At sidebar, choose `Rich Presence` > `Art Assets`

  ![image](https://github.com/michioxd/TinyDRPC/assets/80969068/645b2167-9d2a-4c3b-b7d1-5cc4b56aa31f)

- Add a image, then save change. The image key is your name file (without extension) you uploaded. You can rename it if you want :)
- Copy that name (key) and enjoy!

## License 

[MIT License](LICENSE.txt)
