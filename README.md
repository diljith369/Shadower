
    ███████╗██╗  ██╗ █████╗ ██████╗  ██████╗ ██╗    ██╗██████╗ ██████╗ 
    ██╔════╝██║  ██║██╔══██╗██╔══██╗██╔═████╗██║    ██║╚════██╗██╔══██╗
    ███████╗███████║███████║██║  ██║██║██╔██║██║ █╗ ██║ █████╔╝██████╔╝
    ╚════██║██╔══██║██╔══██║██║  ██║████╔╝██║██║███╗██║ ╚═══██╗██╔══██╗
    ███████║██║  ██║██║  ██║██████╔╝╚██████╔╝╚███╔███╔╝██████╔╝██║  ██║
    ╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝  ╚═════╝  ╚══╝╚══╝ ╚═════╝ ╚═╝  ╚═╝
                                                                   

### C2 environment with Controlled ransomware functional simulations. Automated process of generating C2 agents with Remote reflector loading option that limits forensic analysis of agent binary. 
## Things to note
### Provide your C2 server IP / Domain first.
### Build agent with Reflect Loader option. Provide your loader server path where you are going to keep the agent created. 
### Dont forget to provide remote loader agent name too. This remote agent is responsible for loading the agent remotely using reflection.
### Things to note : cmd and ps options are noisy , new processes will be created when using cmd and ps.
### To encrypt files use enc command : enc file(s)path,*.*,false  - encrypts all files in the specified folder and do not change desktop wallpaper (setting final parameter true will make changes to desktop wall paper if the user has enough permissions to perform it)
### Other notable commands
#### pwd , screencount, getscreen <screennumber>, listdir <PathToParentDirectory> , listfiles <PathToParentDirectory>
![Shad0w3R](https://github.com/diljith369/Shadower/blob/main/help.png)
#### Avoided EDR flagged APIS , but you can add more functions and try.
#### Set up needs PostGresql environment and Run sql command inside "PSSQL-Commands.txt" file.
#### Open the shadowerapis solution , Update the GetConnectionString() function inside HelperFunctions.cs with your DB set up details.
#### Note : Whenever you create agent, you have to set up the C2 server path as the IP/Domain of the machine where the shadowerapis.exe is running.
##### For educational pruposes only. Use it with caution. I did not release the Decrypt application with this , either make it yourself or wait for me to release it.
## All generated binaries will be inside 'buildref' folder
## Happy Controlled Simulation
