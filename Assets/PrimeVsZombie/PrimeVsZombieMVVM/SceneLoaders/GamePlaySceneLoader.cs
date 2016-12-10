namespace PrimeVsZombieDB {
    using PrimeVsZombieDB;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.IOC;
    using uFrame.Kernel;
    using uFrame.Kernel.Serialization;
    using uFrame.MVVM;
    using UnityEngine;
    
    
    public class GamePlaySceneLoader : GamePlaySceneLoaderBase {
        
        protected override IEnumerator LoadScene(GamePlayScene scene, Action<float, string> progressDelegate) {
            yield break;
        }
        
        protected override IEnumerator UnloadScene(GamePlayScene scene, Action<float, string> progressDelegate) {
            yield break;
        }
    }
}
