namespace PrimeVsZombieDB {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class PrimeController : PrimeControllerBase {
        
        public override void InitializePrime(PrimeViewModel viewModel) {
            base.InitializePrime(viewModel);
            // This is called when a PrimeViewModel is created
        }
        
        public override void MoveLeft(PrimeViewModel viewModel) {
            base.MoveLeft(viewModel);
        }
        
        public override void MoveRight(PrimeViewModel viewModel) {
            base.MoveRight(viewModel);
        }
        
        public override void MoveUp(PrimeViewModel viewModel) {
            base.MoveUp(viewModel);
        }
        
        public override void MoveDown(PrimeViewModel viewModel) {
            base.MoveDown(viewModel);
        }
    }
}
