using System.ServiceModel.Dispatcher;
using System;
using StructureMap;
using System.ServiceModel;
using System.ServiceModel.Channels;

public class StructureMapInstanceProvider : IInstanceProvider
{
    private Type _serviceType;

    public StructureMapInstanceProvider(Type serviceType)
    {
        this._serviceType = serviceType;
    }

    public object GetInstance(InstanceContext instanceContext, Message message)
    {
        return ObjectFactory.GetInstance(_serviceType);
    }

    public object GetInstance(InstanceContext instanceContext)
    {
        return this.GetInstance(instanceContext, null);
    }

    //public override Type BehaviorType
    //{
    //    get { return this.GetType(); }
    //}

    //protected override object CreateBehavior()
    //{
    //    ObjectFactory.Initialize(cfg =>
    //    {
    //        cfg.Scan(scan =>
    //        {
    //            scan.WithDefaultConventions();
    //        });
    //    });
    //    return this;
    //}

    public void ReleaseInstance(InstanceContext instanceContext, object instance)
    {

    }
}