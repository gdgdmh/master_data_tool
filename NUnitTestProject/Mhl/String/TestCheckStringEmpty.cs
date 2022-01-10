using NUnit.Framework;

namespace NUnitTestProject.Mhl.String
{
	public class TestCheckStringEmpty
	{
		[SetUp]
		public void Setup()
		{
		}

		/// <summary>
		/// �󕶎����true��Ԃ���
		/// </summary>
		[Test]
		public void TestEmptyStringTrue()
		{
			global::Mhl.String.CheckStringEmpty check = new global::Mhl.String.CheckStringEmpty();
			string str = new string("");
			Assert.IsTrue(check.IsEmpty(str));
		}

		/// <summary>
		/// null�̕�����N���X��true��Ԃ���
		/// </summary>
		[Test]
		public void TestNullTrue()
		{
			global::Mhl.String.CheckStringEmpty check = new global::Mhl.String.CheckStringEmpty();
			string str = null;
			Assert.IsTrue(check.IsEmpty(str));
		}

		/// <summary>
		/// ������Abc��false��Ԃ���
		/// </summary>
		[Test]
		public void TestAbcFalse()
		{
			global::Mhl.String.CheckStringEmpty check = new global::Mhl.String.CheckStringEmpty();
			string str = new string("Abc");
			Assert.IsFalse(check.IsEmpty(str));
		}
	}
}