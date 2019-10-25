using Esquio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsquioFeatureToggleInNetCore
{
    public class EsquioObserver : IObserver<KeyValuePair<string, object>>
    {
        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(KeyValuePair<string, object> item)
        {
            var isEndEvent = item.Key.Contains(EsquioConstants.ESQUIO_BEGINFEATURE_ACTIVITY_NAME);

            if (isEndEvent)
            {
                var value = item.Value;
            }
        }
    }
}
