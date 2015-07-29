using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    //Soluzione più semplice
    public interface IModelPersister
    {
        IModelLoader GetLoader();

        void Save(Model model);
    }

    public interface IModelLoader
    {
        Videogiochi LoadVideogiochi();

        Recensioni LoadRecensioni();

        //gli aspetti vengono popolati automaticamente dal reference counting
        //Aspetti LoadAspetti();

        UtentiRegistrati LoadUtentiRegistrati();
    }


}
