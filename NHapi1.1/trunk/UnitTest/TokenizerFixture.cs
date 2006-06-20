using System;
using System.Collections;
using System.Text;

using NUnit.Framework;
using ca.uhn;
using Tokenizer = ca.uhn.SupportClass.Tokenizer;

namespace NHAPI.NUnit
{

	/// <summary>
	/// Class to test SupportClass.Tokenizer.
	/// </summary>
	/// <remarks>
	/// Tokenizer was changed from the standard JLCA implementation so this class
	/// was created to excercise functionality before and after.
	/// </remarks>
	[TestFixture]
	public class TokenizerFixture
	{
		[Test]
		public void EmptyString()
		{
			Tokenizer t = new Tokenizer(string.Empty);

			Assert.IsFalse(t.HasMoreTokens());
			Assert.AreEqual(0, t.Count);
		}

		[Test, ExpectedException(typeof(System.NullReferenceException))]
		public void NullStringThrows()
		{
			Tokenizer t = new Tokenizer(null);
		}

		[Test]
		public void StringWithNoTokens()
		{
			Tokenizer t = new Tokenizer("somestring");
			Assert.AreEqual(1, t.Count);
			Assert.IsTrue(t.HasMoreTokens());

			Assert.AreEqual("somestring", t.NextToken());
		}

		[Test]
		public void InteriorSingleDelimiter()
		{
			Tokenizer t = new Tokenizer("some\tstring");
			Assert.AreEqual(2, t.Count);

			Assert.AreEqual("some", t.NextToken());

			Assert.AreEqual(1, t.Count);
			Assert.IsTrue(t.HasMoreTokens());

			Assert.AreEqual("string", t.NextToken());

			Assert.IsFalse(t.HasMoreTokens());
		}

		[Test]
		public void EndingDelimiter()
		{
			Tokenizer t = new Tokenizer("somestring\t");
			Assert.AreEqual(1, t.Count);
			Assert.IsTrue(t.HasMoreTokens());
			Assert.AreEqual("somestring", t.NextToken());
			Assert.IsFalse(t.HasMoreTokens());
		}

		[Test]
		public void MixedInteriorDelimiters()
		{
			Tokenizer t = new Tokenizer("some\tstring and\rvalues");
			Assert.AreEqual(4, t.Count);
			Assert.IsTrue(t.HasMoreTokens());
			Assert.AreEqual("some",t.NextToken());
			Assert.AreEqual("string",t.NextToken());
			Assert.AreEqual("and",t.NextToken());
			Assert.AreEqual("values",t.NextToken());

			Assert.IsFalse(t.HasMoreTokens());
			Assert.AreEqual(0, t.Count);
		}

		[Test]
		public void CustomDelimiaters()
		{
			Tokenizer t = new Tokenizer("my|custom|delimiter", "|");
			Assert.AreEqual(3,t.Count);
			Assert.IsTrue(t.HasMoreTokens());
			Assert.AreEqual("my", t.NextToken());
			Assert.AreEqual("custom", t.NextToken());
			Assert.AreEqual("delimiter", t.NextToken());

			Assert.IsFalse(t.HasMoreTokens());
			Assert.AreEqual(0, t.Count);
		}

		[Test]
		public void PassCustomDelimiter()
		{
			Tokenizer t = new Tokenizer("normal delimiters|then|custom");
			Assert.AreEqual(2, t.Count);
			Assert.IsTrue(t.HasMoreTokens());
			Assert.AreEqual("normal", t.NextToken());


			Assert.AreEqual(" delimiters", t.NextToken("|"));
			Assert.AreEqual("then", t.NextToken("|"));
			Assert.AreEqual("custom", t.NextToken("|"));

			Assert.IsFalse(t.HasMoreTokens());
			Assert.AreEqual(0, t.Count);
		}

		[Test]
		public void ReturnDelimiters()
		{
			Tokenizer t = new Tokenizer("this is a test string", " ", true);
			Assert.AreEqual(9, t.Count);
			Assert.IsTrue(t.HasMoreTokens());

			Assert.AreEqual("this", t.NextToken());
			Assert.AreEqual(" ", t.NextToken());
			Assert.AreEqual("is", t.NextToken());
			Assert.AreEqual(" ", t.NextToken());
			Assert.AreEqual("a", t.NextToken());
			Assert.AreEqual(" ", t.NextToken());
			Assert.AreEqual("test", t.NextToken());
			Assert.AreEqual(" ", t.NextToken());
			Assert.AreEqual("string", t.NextToken());

			Assert.IsFalse(t.HasMoreTokens());
			Assert.AreEqual(0, t.Count);
		}
        
	}
}
