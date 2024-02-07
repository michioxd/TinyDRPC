# TinyDRPC

Tiny Discord Rich Presence Client, customize your "Playing" status, written in C# using [discord-rpc-csharp](https://github.com/Lachee/discord-rpc-csharp)

![image](https://github.com/michioxd/TinyDRPC/assets/80969068/bdfbd836-d25b-4b33-8af0-dfd12dd55c93)

![image](https://github.com/michioxd/TinyDRPC/assets/80969068/5d1a8e6a-ae82-4a60-af05-3edc38e7b0ba)

## Features

- Top and bottom text
- Button
- Large/small image
- Run on startup
- Save running state for next startup

## Usage

- Download [setup from release page](https://github.com/michioxd/TinyDRPC/releases/latest).
- Install it then run it (or you can download portable version).
- Customize setting for your own.

## Tutorial

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
