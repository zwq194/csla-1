﻿using System;

namespace Csla.Serialization.Mobile
{
  /// <summary>
  /// Factory used to create the appropriate
  /// serialization formatter object based
  /// on the application configuration.
  /// </summary>
  public static class SerializationFormatterFactory
  {
    /// <summary>
    /// Creates a serialization formatter object.
    /// </summary>
    public static ISerializationFormatter GetFormatter()
    {
      return new MobileFormatter();
    }
  }
}
