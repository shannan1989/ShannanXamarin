using System;
using System.IO;
using System.Net;

namespace CodingHard
{
	public class DataRequest : IDisposable
	{
		private HttpWebRequest _request;
		private HttpWebResponse _response;
		private Stream _responseStream;
		private MemoryStream _ms;

		static DataRequest()
		{
			
		}

		public DataRequest()
		{
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				Clean();
			}
		}

		private void Clean()
		{
			if (_ms != null)
			{
				//_ms.Close();
				_ms = null;
			}

			if (_responseStream != null)
			{
				//_responseStream.Close();
				_responseStream = null;
			}

			if (_response != null)
			{
				//_response.Close();
				_response = null;
			}

			_request = null;
		}
	}
}

