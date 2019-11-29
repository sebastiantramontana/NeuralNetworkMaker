using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkMaker
{
   public static class CoreExtensions
   {
      public static SameObject<TResult> GetSameForAll<TElement, TResult>(this IEnumerable<TElement> elements, Func<TElement, TResult> predicate)
      {
         var distinctElements = elements?.Select(predicate).Distinct();

         bool isTheSame = distinctElements != null && distinctElements.Count() == 1;
         TResult result = isTheSame ? distinctElements.Single() : default;

         return new SameObject<TResult>(isTheSame, result);
      }
   }
}
