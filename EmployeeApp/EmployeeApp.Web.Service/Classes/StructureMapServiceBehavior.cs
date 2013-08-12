using System.ServiceModel.Description;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.Collections;
using System.Collections.ObjectModel;
using System.ServiceModel.Channels;
public class StructureMapServiceBehavior : IServiceBehavior
{
    public void ApplyDispatchBehavior(ServiceDescription desc, ServiceHostBase host)
    {
        foreach (ChannelDispatcherBase cdb in host.ChannelDispatchers)
        {
            ChannelDispatcher cd = cdb as ChannelDispatcher;
            if (cd != null)
            {
                foreach (EndpointDispatcher ed in cd.Endpoints)
                {
                    ed.DispatchRuntime.InstanceProvider =
                        new StructureMapInstanceProvider(desc.ServiceType);
                }
            }
        }
    }

    public void AddBindingParameters(ServiceDescription desc, ServiceHostBase host, Collection<ServiceEndpoint> endpoint, 
                                     BindingParameterCollection bindingParameters)
    {
    }

    public void Validate(ServiceDescription desc, ServiceHostBase host)
    {
    }
}