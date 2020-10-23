namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Por OCP llegamos a la conclusión de que era necesario crear una clase abstracta BaseStep,
    /// de esta forma, si fuese necesario crear otro tipo de Step que haga algo distinto,
    /// simplemente se crearía la clase y heredaría de BaseStep.
    /// De tal manera que a la hora de, por ejemplo, calcular el total de producción, 
    /// no habría que modificar el método si se quisiese agregar otros tipos de Step.
    /// </summary>
    public abstract class BaseStep
    {
        public abstract double GetStepCost();

        public abstract string GetTextToPrint();
    }
}