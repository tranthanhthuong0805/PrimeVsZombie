using uFrame.MVVM;
using UniRx;
using UnityEngine.UI;

namespace PrimeVsZombieDB {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class GamePlayController : GamePlayControllerBase {
        
        public override void InitializeGamePlay(GamePlayViewModel viewModel) {
            base.InitializeGamePlay(viewModel);
            // This is called when a GamePlayViewModel is created

            viewModel.PrimeProperty
                .Where(prime => prime != null)
                .Subscribe(prime => OnChangePrime(viewModel, prime));

            viewModel.ZombiesProperty
                .Where(zombie => zombie != null)
                .Subscribe(zombie => OnChangeZombie(viewModel, zombie));

            //Observable.Interval(TimeSpan.FromSeconds(UnityEngine.Random.Range(2, 4))).Subscribe(_ =>
            //{
            //    var zombie = this.CreateViewModel<ZombieViewModel>();

            //    viewModel.Zombies.Add(zombie);
            //});

            Observable.FromCoroutine(() => LoadComponents(viewModel))
                .Subscribe(i => { }, _ => { });
        }

        private IEnumerator LoadComponents(GamePlayViewModel viewModel)
        {
            var prime = this.CreateViewModel<PrimeViewModel>();
            viewModel.Prime = prime;

            var zombie = this.CreateViewModel<ZombieViewModel>();
            viewModel.Zombies = zombie;

            return null;
        }

        private void OnChangePrime(GamePlayViewModel viewModel, PrimeViewModel prime)
        {
        }

        private void OnChangeZombie(GamePlayViewModel viewModel, ZombieViewModel zombie)
        {
        }
    }
}
