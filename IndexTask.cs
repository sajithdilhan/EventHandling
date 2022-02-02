using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling
{
    class IndexTask
    {
        public event EventHandler<string> Indexing;
        public event EventHandler<string> IndexingFinished;
        public void IndexProducts()
        {
            for (int i = 0; i < 10000; i++)
            {
                OnIndexing(i.ToString());
            }

            OnIndexingFinished("9999");
        }

        public virtual void OnIndexing(string index)
        {
            Indexing?.Invoke(this, index);
        }

        public virtual void OnIndexingFinished(string lastIndex)
        {
            IndexingFinished?.Invoke(this, lastIndex);
        }


    }
}
