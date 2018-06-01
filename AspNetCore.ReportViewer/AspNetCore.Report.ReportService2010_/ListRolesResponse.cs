﻿
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ServiceModel;


namespace AspNetCore.Report.ReportService2010_
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	[MessageContract(WrapperName = "ListRolesResponse", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class ListRolesResponse
	{
		[MessageHeader]
		public ServerInfoHeader ServerInfoHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public Role[] Roles;

		public ListRolesResponse()
		{
		}

		public ListRolesResponse(ServerInfoHeader ServerInfoHeader, Role[] Roles)
		{
			this.ServerInfoHeader = ServerInfoHeader;
			this.Roles = Roles;
		}
	}
}