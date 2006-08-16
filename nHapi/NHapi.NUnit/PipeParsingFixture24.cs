using System;
using System.Collections;
using System.Text;

using NHapi.Base;
using NUnit.Framework;

namespace NHAPI.NUnit
{

	[TestFixture]
	public class PipeParsingFixture24
	{
		[Test]
		public void ParseQRYR02()
		{
			string message = @"MSH|^~\&|CohieCentral|COHIE|Clinical Data Provider|TCH|20060228155525||QRY^R02^QRY_R02|1|P|2.4|
QRD|20060228155525|R|I||||10^RD&Records&0126|38923^^^^^^^^&TCH|||";

			NHapi.Base.parser.PipeParser parser = new NHapi.Base.parser.PipeParser();

			NHapi.Base.model.Message m = parser.parse(message);

			NHapi.Base.model.v24.message.QRY_R02 qryR02 = m as NHapi.Base.model.v24.message.QRY_R02;

			Assert.IsNotNull(qryR02);
			Assert.AreEqual("38923", qryR02.QRD.getWhoSubjectFilter(0).IDNumber.Value);
		}

		
		[Test]
		public void ParseORFR04()
		{
			string message = @"MSH|^~\&|Query Result Locator|Query Facility Name|Query Application Name|ST ELSEWHERE HOSPITAL|20051024074506||ORF^R04|432|P|2.4|
MSA|AA|123456789|
QRD|20060228160421|R|I||||10^RD&Records&0126|38923^^^^^^^^&TCH|||
QRF||20050101000000||
PID|||38923^^^ST ELSEWHERE HOSPITAL Medical Record Numbers&              MEDIC              AL RECORD NUMBER&ST ELSEWHERE HOSPITAL^MR^ST ELSEWHERE HOSPITAL||Bombadill^Tom||19450605|M|||1&Main Street^^Littleton^CO^80122||^^^^^303^4376329^22|
OBR|1|0015566|DH2211223|83036^HEMOGLOBIN A1C^^83036^HEMOGLOBIN A1C|||20040526094000|||||||20040526094000||J12345^JENS^JENNY^^^DR^MD^^^^^^^112233&TCH|||||          TP QUEST DIAGNOSTICS-TAMPA 4225 E. FOWLER AVE TAMPA          FL 33617|20030622070400|||F|
OBX|1|NM|50026400^HEMOGLOBIN A1C^^50026400^HEMOGLOBIN A1C||12|^% TOTAL HGB|4.0 - 6.0|H|||F|||20040510094000|TP^^L|";

			NHapi.Base.parser.PipeParser parser = new NHapi.Base.parser.PipeParser();

			NHapi.Base.model.Message m = parser.parse(message);

			NHapi.Base.model.v24.message.ORF_R04 orfR04 = m as NHapi.Base.model.v24.message.ORF_R04;
			Assert.IsNotNull(orfR04);
			Assert.AreEqual("12", orfR04.getRESPONSE().getORDER().getOBSERVATION().OBX.getObservationValue()[0].Data.ToString());

		}

		[Test]
		public void ParseORFR04ToXML()
		{
			string message = @"MSH|^~\&|Query Result Locator|Query Facility Name|Query Application Name|ST ELSEWHERE HOSPITAL|20051024074506||ORF^R04|432|P|2.4|
MSA|AA|123456789|
QRD|20060228160421|R|I||||10^RD&Records&0126|38923^^^^^^^^&TCH|||
QRF||20050101000000||
PID|||38923^^^ST ELSEWHERE HOSPITAL Medical Record Numbers&              MEDIC              AL RECORD NUMBER&ST ELSEWHERE HOSPITAL^MR^ST ELSEWHERE HOSPITAL||Bombadill^Tom||19450605|M|||1&Main Street^^Littleton^CO^80122||^^^^^303^4376329^22|
OBR|1|0015566|DH2211223|83036^HEMOGLOBIN A1C^^83036^HEMOGLOBIN A1C|||20040526094000|||||||20040526094000||J12345^JENS^JENNY^^^DR^MD^^^^^^^112233&TCH|||||          TP QUEST DIAGNOSTICS-TAMPA 4225 E. FOWLER AVE TAMPA          FL 33617|20030622070400|||F|
OBX|1|NM|50026400^HEMOGLOBIN A1C^^50026400^HEMOGLOBIN A1C||12|^% TOTAL HGB|4.0 - 6.0|H|||F|||20040510094000|TP^^L|";

			NHapi.Base.parser.PipeParser parser = new NHapi.Base.parser.PipeParser();

			NHapi.Base.model.Message m = parser.parse(message);

			NHapi.Base.model.v24.message.ORF_R04 orfR04 = m as NHapi.Base.model.v24.message.ORF_R04;

			Assert.IsNotNull(orfR04);

			NHapi.Base.parser.XMLParser xmlParser = new NHapi.Base.parser.DefaultXMLParser();

			string recoveredMessage = xmlParser.encode(orfR04);

			Assert.IsNotNull(recoveredMessage);
			Assert.IsFalse(string.Empty.Equals(recoveredMessage));            
		}

		[Test]
		public void ParseXMLToHL7()
		{
			string message = GetQRYR02XML();

			NHapi.Base.parser.XMLParser xmlParser = new NHapi.Base.parser.DefaultXMLParser();
			NHapi.Base.model.Message m = xmlParser.parse(message);

			NHapi.Base.model.v24.message.QRY_R02 qryR02 = m as NHapi.Base.model.v24.message.QRY_R02;

			Assert.IsNotNull(qryR02);

			NHapi.Base.parser.PipeParser pipeParser = new NHapi.Base.parser.PipeParser();

			string pipeOutput = pipeParser.encode(qryR02);

			Assert.IsNotNull(pipeOutput);
			Assert.IsFalse(string.Empty.Equals(pipeOutput));
		}


		[Test]
		public void ParseORFR04ToXmlNoOCR()
		{
			string message = @"MSH|^~\&|Query Result Locator|Query Facility Name|Query Application Name|ST ELSEWHERE HOSPITAL|20051024074506||ORF^R04|432|P|2.4|
MSA|AA|123456789|
QRD|20060228160421|R|I||||10^RD&Records&0126|38923^^^^^^^^&TCH|||
QRF||20050101000000||
PID|||38923^^^ST ELSEWHERE HOSPITAL Medical Record Numbers&              MEDIC              AL RECORD NUMBER&ST ELSEWHERE HOSPITAL^MR^ST ELSEWHERE HOSPITAL||Bombadill^Tom||19450605|M|||1&Main Street^^Littleton^CO^80122||^^^^^303^4376329^22|
OBR|1|0015566|DH2211223|83036^HEMOGLOBIN A1C^^83036^HEMOGLOBIN A1C|||20040526094000|||||||20040526094000||J12345^JENS^JENNY^^^DR^MD^^^^^^^112233&TCH|||||          TP QUEST DIAGNOSTICS-TAMPA 4225 E. FOWLER AVE TAMPA          FL 33617|20030622070400|||F|
OBX|1|NM|50026400^HEMOGLOBIN A1C^^50026400^HEMOGLOBIN A1C||12|^% TOTAL HGB|4.0 - 6.0|H|||F|||20040510094000|TP^^L|";

			NHapi.Base.parser.PipeParser parser = new NHapi.Base.parser.PipeParser();

			NHapi.Base.model.Message m = parser.parse(message);

			NHapi.Base.model.v24.message.ORF_R04 orfR04 = m as NHapi.Base.model.v24.message.ORF_R04;

			Assert.IsNotNull(orfR04);

			NHapi.Base.parser.XMLParser xmlParser = new NHapi.Base.parser.DefaultXMLParser();

			string recoveredMessage = xmlParser.encode(orfR04);

			Assert.IsNotNull(recoveredMessage);
			Assert.IsFalse(recoveredMessage.IndexOf("ORC")>-1, "Returned message added ORC segment.");
		}

		[Test]
		public void ParseORFR04ToXmlNoNTE()
		{
			string message = @"MSH|^~\&|Query Result Locator|Query Facility Name|Query Application Name|ST ELSEWHERE HOSPITAL|20051024074506||ORF^R04|432|P|2.4|
MSA|AA|123456789|
QRD|20060228160421|R|I||||10^RD&Records&0126|38923^^^^^^^^&TCH|||
QRF||20050101000000||
PID|||38923^^^ST ELSEWHERE HOSPITAL Medical Record Numbers&              MEDIC              AL RECORD NUMBER&ST ELSEWHERE HOSPITAL^MR^ST ELSEWHERE HOSPITAL||Bombadill^Tom||19450605|M|||1&Main Street^^Littleton^CO^80122||^^^^^303^4376329^22|
OBR|1|0015566|DH2211223|83036^HEMOGLOBIN A1C^^83036^HEMOGLOBIN A1C|||20040526094000|||||||20040526094000||J12345^JENS^JENNY^^^DR^MD^^^^^^^112233&TCH|||||          TP QUEST DIAGNOSTICS-TAMPA 4225 E. FOWLER AVE TAMPA          FL 33617|20030622070400|||F|
OBX|1|NM|50026400^HEMOGLOBIN A1C^^50026400^HEMOGLOBIN A1C||12|^% TOTAL HGB|4.0 - 6.0|H|||F|||20040510094000|TP^^L|";

			NHapi.Base.parser.PipeParser parser = new NHapi.Base.parser.PipeParser();

			NHapi.Base.model.Message m = parser.parse(message);

			NHapi.Base.model.v24.message.ORF_R04 orfR04 = m as NHapi.Base.model.v24.message.ORF_R04;

			Assert.IsNotNull(orfR04);

			NHapi.Base.parser.XMLParser xmlParser = new NHapi.Base.parser.DefaultXMLParser();

			string recoveredMessage = xmlParser.encode(orfR04);

			Assert.IsNotNull(recoveredMessage);
			Assert.IsFalse(recoveredMessage.IndexOf("NTE")>-1, "Returned message added ORC segment.");
		}

         
        
        private static string GetQRYR02XML() 
		{
			return @"<QRY_R02 xmlns=""urn:hl7-org:v2xml"">
  <MSH>
    <MSH.1>|</MSH.1>
    <MSH.2>^~\&amp;</MSH.2>
    <MSH.1 />
    <MSH.2 />
    <MSH.3>
      <HD.1>CohieCentral</HD.1>
    </MSH.3>
    <MSH.4>
      <HD.1>COHIE</HD.1>
    </MSH.4>
    <MSH.5>
      <HD.1>Clinical Data Provider</HD.1>
    </MSH.5>
    <MSH.6>
      <HD.1>UCH</HD.1>
    </MSH.6>
    <MSH.7>
      <TS.1>20060228152640</TS.1>
    </MSH.7>
    <MSH.9>
      <MSG.1>QRY</MSG.1>
      <MSG.2>R02</MSG.2>
      <MSG.3>QRY_R02</MSG.3>
    </MSH.9>
    <MSH.10>1</MSH.10>
    <MSH.11>
      <PT.1>P</PT.1>
    </MSH.11>
    <MSH.12>
      <VID.1>2.4</VID.1>
    </MSH.12>
  </MSH>
  <QRD>
    <QRD.1>
      <TS.1>20060228152640</TS.1>
    </QRD.1>
    <QRD.2>R</QRD.2>
    <QRD.3>I</QRD.3>
    <QRD.4></QRD.4>
    <QRD.7>
      <CQ.1>10</CQ.1>
      <CQ.2>
        <CE.1>RD</CE.1>
        <CE.2>Records</CE.2>
        <CE.3>0126</CE.3>
      </CQ.2>
    </QRD.7>
    <QRD.8>
      <XCN.1>99388244</XCN.1>
      <XCN.9>
        <HD.2>UCH</HD.2>
      </XCN.9>
    </QRD.8>
    <QRD.9 />
    <QRD.10 />
  </QRD>
  <QRF>
    <QRF.1 />
    <QRF.2>
      <TS.1>20050101000000</TS.1>
    </QRF.2>
    <QRF.3 />
  </QRF>
</QRY_R02>
";
		}
	}
}
