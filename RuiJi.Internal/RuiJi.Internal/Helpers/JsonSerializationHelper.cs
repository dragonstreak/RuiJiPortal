using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;

namespace RuiJi.Internal.Helpers
{
	public class JsonSerializationHelper
	{
		/// <summary>
		/// Serializes the specified obj.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="obj">The obj.</param>
		/// <returns></returns>
		public static string Serialize<T>(T obj)
		{
			DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
			MemoryStream ms = new MemoryStream();
			serializer.WriteObject(ms, obj);
			string retVal = Encoding.Default.GetString(ms.ToArray());
			ms.Dispose();
			return retVal;
		}

		/// <summary>
		/// Deserializes the specified json.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="json">The json.</param>
		/// <returns></returns>
		public static T Deserialize<T>(string json)
		{
			T obj = Activator.CreateInstance<T>();
			MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(json));
			DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
			obj = (T)serializer.ReadObject(ms);
			ms.Close();
			ms.Dispose();
			return obj;
		}

	}
}