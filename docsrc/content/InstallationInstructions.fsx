(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../bin/FSharpGephiStreamer/net47"
#r "FSharpGephiStreamer.dll"
open FSharpGephiStreamer
let a = "http://my-ip"
let b = 1337
let c = "yourWorkspace"
let usrConfig = sprintf "http://%s:%i/%s/?operation=updateGraph" a b c

(**
#Installation instructions

The following steps are necessary to stream graph data from F# interactive to gephi:

 1. Install [Java](https://www.java.com/en/download/) and [JDK](https://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html)
 2. Install [Gephi](https://gephi.org/users/install/)
 3. Install [Graph streaming plugin](https://gephi.org/plugins/#/plugin/graphstreaming) in gephi:

![](./img/pluginInstallation.jpg)

 4. Enable the master server (default settings:)

![](./img/gephiStreamingServer.gif)

If you want to use another connection than the default connection, you can use the `Streamer.setEnvironment` function to do so:
*)

let currentConfig = Streamer.getEnvirmonment()

(***include-value:currentConfig***)

let yourIp = "my-ip"

let yourPort = 1337

let yourWorkspace = "yourWorkspace"

(***do-not-eval***)
Streamer.setEnvirmonment yourIp yourPort yourWorkspace

(**
Which will change the connection string to your liking:
*)

(***include-value:usrConfig***)