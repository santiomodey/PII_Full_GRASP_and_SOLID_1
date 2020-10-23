//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step: BaseStep
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
        /// <summary>
        ///Por expert vimos necesario que la clase Step fuera la responsable de calcular su propio costo,
        //Ya que es la que tiene toda la información necesaria para ello.
        /// </summary>
        /// <returns></returns>
        public override double GetStepCost()
        {
            return (this.Input.UnitCost * this.Quantity) + (this.Equipment.HourlyCost * this.Time);
        }
        /// <summary>
        /// Agregamos este método para que el método PrintRecipe en Recipe pueda recibir textos distintos
        /// dependiendo del tipo de Step.
        /// </summary>
        /// <returns></returns>
        public override string GetTextToPrint()
        {
            return $"{this.Quantity} de '{this.Input.Description}' " +
            $"usando '{this.Equipment.Description}' durante {this.Time}";
        }
    }
}