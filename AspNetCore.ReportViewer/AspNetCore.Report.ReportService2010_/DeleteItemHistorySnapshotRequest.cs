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
	[MessageContract(WrapperName = "DeleteItemHistorySnapshot", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class DeleteItemHistorySnapshotRequest
	{
		public TrustedUserHeader TrustedUserHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public string ItemPath;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public string HistoryID;

		public DeleteItemHistorySnapshotRequest()
		{
		}

		public DeleteItemHistorySnapshotRequest(TrustedUserHeader TrustedUserHeader, string ItemPath, string HistoryID)
		{
			this.TrustedUserHeader = TrustedUserHeader;
			this.ItemPath = ItemPath;
			this.HistoryID = HistoryID;
		}
	}
}