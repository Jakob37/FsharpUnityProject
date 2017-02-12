namespace FSharp
open UnityEngine
 
type FsharpTestScript() = 
    inherit MonoBehaviour()
    member this.Start() = Debug.Log("Hello World")