namespace GameReViews.Model
{
    public interface IModelPersister
    {
        IModelLoader GetLoader();

        void Save(Document model);
    }

    public interface IModelLoader
    {
        Videogiochi GetVideogiochi();

        //gli aspetti vengono popolati automaticamente dal reference counting
        //Aspetti LoadAspetti();

        UtentiRegistrati GetUtentiRegistrati();
    }
}
