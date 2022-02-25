﻿using Chloe.Query;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Chloe.Sharding
{
    internal class ShardingOrderedQuery<T> : ShardingQuery<T>, IOrderedQuery<T>
    {
        public ShardingOrderedQuery(IOrderedQuery<T> query) : base(query)
        {

        }

        public IOrderedQuery<T> ThenBy<K>(Expression<Func<T, K>> keySelector)
        {
            return new ShardingOrderedQuery<T>((this.InnerQuery as IOrderedQuery<T>).ThenBy(keySelector));
        }
        public IOrderedQuery<T> ThenByDesc<K>(Expression<Func<T, K>> keySelector)
        {
            return new ShardingOrderedQuery<T>((this.InnerQuery as IOrderedQuery<T>).ThenByDesc(keySelector));
        }
    }
}
