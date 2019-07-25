﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NeuralNetworkMaker.Preferences.Extensions
{
   public static class Enums
   {
      public static void Reload<TEnum>(this ComboBox comboBox, IEnumerable<TEnum> items) where TEnum : Enum
      {
         comboBox.Items.Clear();
         comboBox.Items.AddRange(items.Cast<object>().ToArray());
      }

      public static void Load<TEnum>(this ComboBox comboBox) where TEnum : Enum
      {
         comboBox.Items.Clear();
         comboBox.AddRange<TEnum>();
      }

      public static void Load<TEnum>(this ComboBox comboBox, IEnumerable<TEnum> except) where TEnum : Enum
      {
         comboBox.Items.Clear();
         comboBox.AddRange<TEnum>(except);
      }

      public static void AddRange<TEnum>(this ComboBox comboBox) where TEnum : Enum
      {
         comboBox.Items.AddRange(EnumsToObjects<TEnum>()
            .ToArray());
      }

      public static void AddRange<TEnum>(this ComboBox comboBox, IEnumerable<TEnum> except) where TEnum : Enum
      {
         comboBox.Items.AddRange(EnumsToObjects<TEnum>()
            .Except(except.Cast<object>())
            .ToArray());
      }

      private static IEnumerable<object> EnumsToObjects<TEnum>() where TEnum : Enum
      {
         return Enum.GetValues(typeof(TEnum))
            .Cast<object>();
      }
   }
}
