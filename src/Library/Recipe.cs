//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        //Se cambió para que concuerde con OCP explicado en BaseStep
        private IList<BaseStep> steps = new List<BaseStep>();

        public Product FinalProduct { get; set; }
        //Se cambió para que concuerde con OCP explicado en BaseStep
        public void AddStep(BaseStep step)
        {
            this.steps.Add(step);
        }
        //Se cambió para que concuerde con OCP explicado en BaseStep
        public void RemoveStep(BaseStep step)
        {
            this.steps.Remove(step);
        }
        /*
        Como comentario, creemos que este método debería cambiar ya que solo permite la impresión en consola.
        */
        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (BaseStep step in this.steps)
            {
               Console.WriteLine(step.GetTextToPrint());
            }
            Console.WriteLine( $"Costo de producción: {this.GetProductionCost()}");
        }
        /// <summary>
        /// Al ser Recipe la única clase que conoce todos los steps ya que los tiene en una lista, 
        /// por expert llegamos a la conclusión de que sería buena idea colocar aqui la responsabilidad de
        /// calcular el costo de producción.
        /// </summary>
        /// <returns></returns>
        public double GetProductionCost()
        {
        double result = 0;
        foreach (BaseStep step in this.steps)
            {
                result = result + step.GetStepCost();
            }
            return result;
        }
    }
}