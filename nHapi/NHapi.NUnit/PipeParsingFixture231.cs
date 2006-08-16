using System;
using System.Collections;
using System.Text;

using NHapi.Base;
using NUnit.Framework;

namespace NHAPI.NUnit
{

	[TestFixture]
	public class PipeParsingFixture231
	{
		[Test]
		public void ParseQRYR02()
		{
			string message = @"MSH|^~\&|CohieCentral|COHIE|Clinical Data Provider|TCH|20060228155525||QRY^R02^QRY_R02|1|P|2.3.1|
QRD|20060228155525|R|I||||10^RD&Records&0126|38923^^^^^^^^&TCH|||";

			NHapi.Base.parser.PipeParser parser = new NHapi.Base.parser.PipeParser();

			NHapi.Base.model.Message m = parser.parse(message);

			NHapi.Base.model.v231.message.QRY_R02 qryR02 = m as NHapi.Base.model.v231.message.QRY_R02;

			Assert.IsNotNull(qryR02);
			Assert.AreEqual("38923", qryR02.QRD.getWhoSubjectFilter(0).IDNumber.Value);
		}

        [Test]
        public void ParseORMo01PIDSegment()
        {
            string message = @"MSH|^~\&|INVISION|DHC|SUNQUEST LAB||200606191615||ORM^O01|ORDR|P|2.3.1|LAB
PID|0001||3020956||TRAINONLYPOE^ONE||19770903|F||W||||||||40230443
PV1|0001|I|MICU^W276^01||||045716^ABAZA, MONA M|||MED|||||||045716|F|000000030188
ORC|NW|01444^00001|||||||||||L
OBR||01444^00001||CAI^CALCIUM IONIZED|||200606191614||||L|||||045716^STEELE, ANDREW W|||||||||||00001&UNITS^ONCE&ONCE^000^200606191614^200606191614^ROUTINE
";

            NHapi.Base.parser.PipeParser parser = new NHapi.Base.parser.PipeParser();

            NHapi.Base.model.Message m = parser.parse(message);

            NHapi.Base.model.v231.message.ORM_O01 ormo01 = m as NHapi.Base.model.v231.message.ORM_O01;

            Assert.IsNotNull(ormo01);
            Assert.AreEqual("TRAINONLYPOE", (ormo01.PATIENT.PID.getPatientName()[0]).FamilyLastName.FamilyName.Value);
            Assert.AreEqual("19770903", ormo01.PATIENT.PID.DateTimeOfBirth.TimeOfAnEvent.Value);
            Assert.AreEqual("F", ormo01.PATIENT.PID.Sex.Value);
            Assert.AreEqual("W", ((ormo01.PATIENT.PID.getRace()[0]).Identifier.Value));

            Assert.AreEqual("ABAZA, MONA M", ormo01.PATIENT.PATIENT_VISIT.PV1.getAttendingDoctor()[0].FamilyLastName.FamilyName.Value);
        }

        [Test]
        public void ParseORMo01ToXml()
        {
            string message = @"MSH|^~\&|INVISION|DHC|SUNQUEST LAB||200606191615||ORM^O01|ORDR|P|2.3.1|LAB
PID|0001||3020956||TRAINONLYPOE^ONE||19770903|F||W||||||||40230443
PV1|0001|I|MICU^W276^01||||045716^ABAZA, MONA M|||MED|||||||045716|F|000000030188
ORC|NW|01444^00001|||||||||||L
OBR||01444^00001||CAI^CALCIUM IONIZED|||200606191614||||L|||||045716^STEELE, ANDREW W|||||||||||00001&UNITS^ONCE&ONCE^000^200606191614^200606191614^ROUTINE
";

            NHapi.Base.parser.PipeParser parser = new NHapi.Base.parser.PipeParser();

            NHapi.Base.model.Message m = parser.parse(message);

            NHapi.Base.model.v231.message.ORM_O01 ormo01 = m as NHapi.Base.model.v231.message.ORM_O01;

            NHapi.Base.parser.XMLParser xmlParser = new NHapi.Base.parser.DefaultXMLParser();

            string recoveredMessage = xmlParser.encode(ormo01);

            Assert.AreNotEqual(string.Empty, recoveredMessage);

            System.Xml.XmlDocument ormDoc = new System.Xml.XmlDocument();
            ormDoc.LoadXml(recoveredMessage);
            Assert.IsNotNull(ormDoc);
       }

        [Test]
        public void ParseORRo02ToXml()
        {
            string message = @"MSH|^~\&|INVISION|DHC|SUNQUEST LAB||200607100719||ORR^O02|ORDR|T|2.3.1|LAB
PID|0001||3017864||HILBERT^MARY||19440823|F||W||||||||40244246
PV1|0001|O|LW||||888883^DOCTOR, UNASSIGNED||||||||||888883|O|000000031540
ORC|NA|00003^00001|F1492|||||||||888883
OBR||00003^00001|F1492|RESPC^CULTURE RESPIRATORY ROUTINE|||||||L|||||||||F1492|||||||^ONCE&ONCE^^200607070600^200607070600^ROUTINE
";

            NHapi.Base.parser.PipeParser parser = new NHapi.Base.parser.PipeParser();

            NHapi.Base.model.Message m = parser.parse(message);

            NHapi.Base.model.v231.message.ORR_O02 msg = m as NHapi.Base.model.v231.message.ORR_O02;

            NHapi.Base.parser.XMLParser xmlParser = new NHapi.Base.parser.DefaultXMLParser();

            string recoveredMessage = xmlParser.encode(msg);

            Assert.AreNotEqual(string.Empty, recoveredMessage);

            System.Xml.XmlDocument orrDoc = new System.Xml.XmlDocument();
            orrDoc.LoadXml(recoveredMessage);
            Assert.IsNotNull(orrDoc);
        }


        [Test]
        public void ParseORUr01LongToXml()
        {
            string message = @"MSH|^~\$|LAB|DHC|LCR|DH|200511291403||ORU^R01|52780002432|P|2.3.1
PID|0001|3013839|40206609||BARNES^TEST||19551005|F|||||||||||258452152
OBR||00009^001|W442|CBC^CBC|||200509210520||||||||CBC^CBC|117564^STEEL||||||||DAH
OBX|1|NM|WBC||20.0|k/uL|4.5-10.0|H|||Z
OBX|1|TX|WBC|1|(Ref Range: 4 k/uL)|k/uL|4.5-10.0||||Z
OBX|2|NM|RBC||4.00|M/uL|4.20-5.40|L|||Z
OBX|2|TX|RBC|1|(Ref Range: 4 M/uL)|M/uL|4.20-5.40||||Z
OBX|3|NM|HGB||12.0|g/dL|14.0-24.0|L|||Z
OBX|3|TX|HGB|1|(Ref Range: 1 g/dL)|g/dL|14.0-24.0||||Z
OBX|4|NM|HCT||41.0|%|37.0-47.0||||Z
OBX|4|TX|HCT|1|(Ref Range: 3 %)|%|37.0-47.0||||Z
OBX|5|NM|MCV||80.9|fl|80.0-100.0||||Z
OBX|5|TX|MCV|1|(Ref Range: 8 fl)|fl|80.0-100.0||||Z
OBX|6|NM|MCH||31.0|pg|27.0-31.0||||Z
OBX|6|TX|MCH|1|(Ref Range: 2 pg)|pg|27.0-31.0||||Z
OBX|7|NM|MCHC||32.0|g/dL|32.0-36.0||||Z
OBX|7|TX|MCHC|1|(Ref Range: 3 g/dL)|g/dL|32.0-36.0||||Z
OBX|8|NM|RDW||19.0|%|11.5-14.5|H|||Z
OBX|8|TX|RDW|1|(Ref Range: 1 %)|%|11.5-14.5||||Z
OBX|9|NM|PLTC||45|k/uL|150-400|PL^Y|||Z
OBX|9|TX|PLTC|1|(Ref Range: 1 k/uL)|k/uL|150-400||||Z
OBX|10|NM|MPV||10.0|fL|6.2-10.0||||Z
OBX|10|TX|MPV|1|(Ref Range: 6 fL)|fL|6.2-10.0||||Z
";

            NHapi.Base.parser.PipeParser parser = new NHapi.Base.parser.PipeParser();

            NHapi.Base.model.Message m = parser.parse(message);

            NHapi.Base.model.v231.message.ORU_R01 msg = m as NHapi.Base.model.v231.message.ORU_R01;

            NHapi.Base.parser.XMLParser xmlParser = new NHapi.Base.parser.DefaultXMLParser();

            string recoveredMessage = xmlParser.encode(msg);

            Assert.AreNotEqual(string.Empty, recoveredMessage);

            System.Xml.XmlDocument orrDoc = new System.Xml.XmlDocument();
            orrDoc.LoadXml(recoveredMessage);
            Assert.IsNotNull(orrDoc);
        }
        
        [Test]
		public void ParseORFR04()
		{
			string message = @"MSH|^~\&|Query Result Locator|Query Facility Name|Query Application Name|ST ELSEWHERE HOSPITAL|20051024074506||ORF^R04|432|P|2.3.1|
MSA|AA|123456789|
QRD|20060228160421|R|I||||10^RD&Records&0126|38923^^^^^^^^&TCH|||
QRF||20050101000000||
PID|||38923^^^ST ELSEWHERE HOSPITAL Medical Record Numbers&              MEDIC              AL RECORD NUMBER&ST ELSEWHERE HOSPITAL^MR^ST ELSEWHERE HOSPITAL||Bombadill^Tom||19450605|M|||1&Main Street^^Littleton^CO^80122||^^^^^303^4376329^22|
OBR|1|0015566|DH2211223|83036^HEMOGLOBIN A1C^^83036^HEMOGLOBIN A1C|||20040526094000|||||||20040526094000||J12345^JENS^JENNY^^^DR^MD^^^^^^^112233&TCH|||||          TP QUEST DIAGNOSTICS-TAMPA 4225 E. FOWLER AVE TAMPA          FL 33617|20030622070400|||F|
OBX|1|NM|50026400^HEMOGLOBIN A1C^^50026400^HEMOGLOBIN A1C||12|^% TOTAL HGB|4.0 - 6.0|H|||F|||20040510094000|TP^^L|";

			NHapi.Base.parser.PipeParser parser = new NHapi.Base.parser.PipeParser();

			NHapi.Base.model.Message m = parser.parse(message);

			NHapi.Base.model.v231.message.ORF_R04 orfR04 = m as NHapi.Base.model.v231.message.ORF_R04;
			Assert.IsNotNull(orfR04);
			Assert.AreEqual("12", orfR04.getQUERY_RESPONSE().getORDER().getOBSERVATION().OBX.getObservationValue()[0].Data.ToString());

		}

		[Test]
		public void ParseORFR04ToXML()
		{
			string message = @"MSH|^~\&|Query Result Locator|Query Facility Name|Query Application Name|ST ELSEWHERE HOSPITAL|20051024074506||ORF^R04|432|P|2.3.1|
MSA|AA|123456789|
QRD|20060228160421|R|I||||10^RD&Records&0126|38923^^^^^^^^&TCH|||
QRF||20050101000000||
PID|||38923^^^ST ELSEWHERE HOSPITAL Medical Record Numbers&              MEDIC              AL RECORD NUMBER&ST ELSEWHERE HOSPITAL^MR^ST ELSEWHERE HOSPITAL||Bombadill^Tom||19450605|M|||1&Main Street^^Littleton^CO^80122||^^^^^303^4376329^22|
OBR|1|0015566|DH2211223|83036^HEMOGLOBIN A1C^^83036^HEMOGLOBIN A1C|||20040526094000|||||||20040526094000||J12345^JENS^JENNY^^^DR^MD^^^^^^^112233&TCH|||||          TP QUEST DIAGNOSTICS-TAMPA 4225 E. FOWLER AVE TAMPA          FL 33617|20030622070400|||F|
OBX|1|NM|50026400^HEMOGLOBIN A1C^^50026400^HEMOGLOBIN A1C||12|^% TOTAL HGB|4.0 - 6.0|H|||F|||20040510094000|TP^^L|";

			NHapi.Base.parser.PipeParser parser = new NHapi.Base.parser.PipeParser();

			NHapi.Base.model.Message m = parser.parse(message);

			NHapi.Base.model.v231.message.ORF_R04 orfR04 = m as NHapi.Base.model.v231.message.ORF_R04;

			Assert.IsNotNull(orfR04);

			NHapi.Base.parser.XMLParser xmlParser = new NHapi.Base.parser.DefaultXMLParser();

			string recoveredMessage = xmlParser.encode(orfR04);

			Assert.IsNotNull(recoveredMessage);
			Assert.IsFalse(string.Empty.Equals(recoveredMessage));            
		}

        /// <summary>
        /// translate a more complex ORM message
        /// </summary>
        [Test]
        public void ParseORMwithOBXToXML()
        {
            string message = @"MSH|^~\&|INVISION|DHC|SUNQUEST LAB||200606191615||ORM^O01|ORDR|P|2.3.1|LAB
PID|0001||3020956||TRAINONLYPOE^ONE||19770903|F||W||||||||40230443
PV1|0001|I|MICU^W276^01||||045716^ABAZA, MONA M|||MED|||||||045716|F|000000030188
ORC|NW|01444^00001|||||||||||L
OBR||01444^00001||CAI^CALCIUM IONIZED|||200606191614||||L|||||045716^STEELE, ANDREW W|||||||||||00001&UNITS^ONCE&ONCE^000^200606191614^200606191614^ROUTINE
OBX||NM|||999||||||
OBX||NM|||999||||||
OBX||NM|||999||||||";

            NHapi.Base.parser.PipeParser parser = new NHapi.Base.parser.PipeParser();

            NHapi.Base.model.Message m = parser.parse(message);

            NHapi.Base.model.v231.message.ORM_O01 msgObj = m as NHapi.Base.model.v231.message.ORM_O01;

            Assert.IsNotNull(msgObj);

            NHapi.Base.parser.XMLParser xmlParser = new NHapi.Base.parser.DefaultXMLParser();

            string recoveredMessage = xmlParser.encode(msgObj);

            Assert.IsNotNull(recoveredMessage);
            Assert.IsFalse(string.Empty.Equals(recoveredMessage));
        }

        /// <summary>
        /// translate a more complex ORM message
        /// </summary>
        [Test]
        public void ParseORMwithCompleteOBXToXML()
        {
            string message = @"MSH|^~\&|INVISION|DHC|SUNQUEST LAB||200606191615||ORM^O01|ORDR|P|2.3.1|LAB
PID|0001||3020956||TRAINONLYPOE^ONE||19770903|F||W||||||||40230443
PV1|0001|I|MICU^W276^01||||045716^ABAZA, MONA M|||MED|||||||045716|F|000000030188
ORC|NW|01444^00001|||||||||||L
OBR||01444^00001||CAI^CALCIUM IONIZED|||200606191614||||L|||||045716^STEELE, ANDREW W|||||||||||00001&UNITS^ONCE&ONCE^000^200606191614^200606191614^ROUTINE
OBX|1|TX|SDES||Blood, peripheral||||||Z
OBX|2|TX|SREQ||LEFT ANTECUBITAL||||||Z
OBX|3|TX|CULT||Beta hemolytic Streptococcus Group A||||||Z
OBX|4|TX|CULT||Critical result(s) called to and verification ";
            message += "\"read-back\"";
            message += @" received from: Nu~||||||Z
";

            NHapi.Base.parser.PipeParser parser = new NHapi.Base.parser.PipeParser();

            NHapi.Base.model.Message m = parser.parse(message);

            NHapi.Base.model.v231.message.ORM_O01 msgObj = m as NHapi.Base.model.v231.message.ORM_O01;

            Assert.IsNotNull(msgObj);

            NHapi.Base.parser.XMLParser xmlParser = new NHapi.Base.parser.DefaultXMLParser();

            string recoveredMessage = xmlParser.encode(msgObj);

            Assert.IsNotNull(recoveredMessage);
            Assert.IsFalse(string.Empty.Equals(recoveredMessage));
        }

        [Test]
		public void ParseXMLToHL7()
		{
			string message = GetQRYR02XML();

			NHapi.Base.parser.XMLParser xmlParser = new NHapi.Base.parser.DefaultXMLParser();
			NHapi.Base.model.Message m = xmlParser.parse(message);

			NHapi.Base.model.v231.message.QRY_R02 qryR02 = m as NHapi.Base.model.v231.message.QRY_R02;

			Assert.IsNotNull(qryR02);

			NHapi.Base.parser.PipeParser pipeParser = new NHapi.Base.parser.PipeParser();

			string pipeOutput = pipeParser.encode(qryR02);

			Assert.IsNotNull(pipeOutput);
			Assert.IsFalse(string.Empty.Equals(pipeOutput));
		}


		[Test]
		public void ParseORFR04ToXmlNoOCR()
		{
			string message = @"MSH|^~\&|Query Result Locator|Query Facility Name|Query Application Name|ST ELSEWHERE HOSPITAL|20051024074506||ORF^R04|432|P|2.3.1|
MSA|AA|123456789|
QRD|20060228160421|R|I||||10^RD&Records&0126|38923^^^^^^^^&TCH|||
QRF||20050101000000||
PID|||38923^^^ST ELSEWHERE HOSPITAL Medical Record Numbers&              MEDIC              AL RECORD NUMBER&ST ELSEWHERE HOSPITAL^MR^ST ELSEWHERE HOSPITAL||Bombadill^Tom||19450605|M|||1&Main Street^^Littleton^CO^80122||^^^^^303^4376329^22|
OBR|1|0015566|DH2211223|83036^HEMOGLOBIN A1C^^83036^HEMOGLOBIN A1C|||20040526094000|||||||20040526094000||J12345^JENS^JENNY^^^DR^MD^^^^^^^112233&TCH|||||          TP QUEST DIAGNOSTICS-TAMPA 4225 E. FOWLER AVE TAMPA          FL 33617|20030622070400|||F|
OBX|1|NM|50026400^HEMOGLOBIN A1C^^50026400^HEMOGLOBIN A1C||12|^% TOTAL HGB|4.0 - 6.0|H|||F|||20040510094000|TP^^L|";

			NHapi.Base.parser.PipeParser parser = new NHapi.Base.parser.PipeParser();

			NHapi.Base.model.Message m = parser.parse(message);

			NHapi.Base.model.v231.message.ORF_R04 orfR04 = m as NHapi.Base.model.v231.message.ORF_R04;

			Assert.IsNotNull(orfR04);

			NHapi.Base.parser.XMLParser xmlParser = new NHapi.Base.parser.DefaultXMLParser();

			string recoveredMessage = xmlParser.encode(orfR04);

			Assert.IsNotNull(recoveredMessage);
			Assert.IsFalse(recoveredMessage.IndexOf("ORC")>-1, "Returned message added ORC segment.");
		}

		[Test]
		public void ParseORFR04ToXmlNoNTE()
		{
			string message = @"MSH|^~\&|Query Result Locator|Query Facility Name|Query Application Name|ST ELSEWHERE HOSPITAL|20051024074506||ORF^R04|432|P|2.3.1|
MSA|AA|123456789|
QRD|20060228160421|R|I||||10^RD&Records&0126|38923^^^^^^^^&TCH|||
QRF||20050101000000||
PID|||38923^^^ST ELSEWHERE HOSPITAL Medical Record Numbers&              MEDIC              AL RECORD NUMBER&ST ELSEWHERE HOSPITAL^MR^ST ELSEWHERE HOSPITAL||Bombadill^Tom||19450605|M|||1&Main Street^^Littleton^CO^80122||^^^^^303^4376329^22|
OBR|1|0015566|DH2211223|83036^HEMOGLOBIN A1C^^83036^HEMOGLOBIN A1C|||20040526094000|||||||20040526094000||J12345^JENS^JENNY^^^DR^MD^^^^^^^112233&TCH|||||          TP QUEST DIAGNOSTICS-TAMPA 4225 E. FOWLER AVE TAMPA          FL 33617|20030622070400|||F|
OBX|1|NM|50026400^HEMOGLOBIN A1C^^50026400^HEMOGLOBIN A1C||12|^% TOTAL HGB|4.0 - 6.0|H|||F|||20040510094000|TP^^L|";

			NHapi.Base.parser.PipeParser parser = new NHapi.Base.parser.PipeParser();

			NHapi.Base.model.Message m = parser.parse(message);

			NHapi.Base.model.v231.message.ORF_R04 orfR04 = m as NHapi.Base.model.v231.message.ORF_R04;

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
      <VID.1>2.3.1</VID.1>
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
