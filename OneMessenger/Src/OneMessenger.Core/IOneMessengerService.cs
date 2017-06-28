﻿using System.ServiceModel;

namespace OneMessenger.Core
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOneMessengerService" in both code and config file together.
	[ServiceContract(CallbackContract=typeof(IClient))]
	public interface IOneMessengerService
	{
		[OperationContract]
		void Test(string value);
	}


}
