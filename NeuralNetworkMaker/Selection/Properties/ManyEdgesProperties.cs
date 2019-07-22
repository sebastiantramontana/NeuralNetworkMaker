﻿using NeuralNetwork.Model.Nodes;
using System.Collections.Generic;

namespace NeuralNetworkMaker.Selection.Properties
{
   public class ManyEdgesProperties : ObjectPropertiesBase
   {
      private readonly IEnumerable<Edge> _edges;

      public ManyEdgesProperties(IEnumerable<Edge> edges)
         :base("Many Edges")
      {
         _edges = edges;
      }

      public double? Weight
      {
         get
         {
            var sameActFunc = _edges.GetSameForAll(e => e.Weight);
            return sameActFunc.IsTheSame ? sameActFunc.Object : null;
         }
         set
         {
            var weight = value;

            foreach (var edge in _edges)
            {
               edge.Weight = weight;
            }
         }
      }
   }
}
