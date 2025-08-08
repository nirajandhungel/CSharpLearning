using System;
namespace Obj
{
    public class SuperCar : Car
    {
        public bool HasTurbo { get; set; }
        public SuperCar(string model, int year, string engineNumber, bool hasTurbo) : base(model, year, engineNumber)
        {
            this.HasTurbo = hasTurbo;
        }
        public override void Start()
        {
            // base.Start();
            if (HasTurbo)
            {
                Console.WriteLine($"{Model} is started using turbo boost");
            }
            ShowNumber();
        }
        public void TurboBoost()
        {
            if (HasTurbo)
            {
                Console.WriteLine($"{Model} is using turbo boost");

            }
            else
            {
                Console.WriteLine($"{Model} has no turbo boost");
                
            }
        }
      
        
    }
}