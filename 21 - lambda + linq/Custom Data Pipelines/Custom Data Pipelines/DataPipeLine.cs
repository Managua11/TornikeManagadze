using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Custom_Data_Pipelines.Program;

namespace Custom_Data_Pipelines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DataPipeline<T, TResult>
    {
        private readonly List<Func<T, bool>> _filters = new List<Func<T, bool>>();
        private readonly List<Func<T, TResult>> _transformers = new List<Func<T, TResult>>();

        public void AddFilter(Func<T, bool> filter)
        {
            _filters.Add(filter);
        }

        public void AddTransformer(Func<T, TResult> transformer)
        {
            _transformers.Add(transformer);
        }

        public IEnumerable<TResult> Process(IEnumerable<T> input)
        {
            var filtered = input.Where(item => _filters.All(filter => filter(item)));
            return filtered.SelectMany(item => _transformers.Select(transformer => transformer(item)));
        }
    }

}