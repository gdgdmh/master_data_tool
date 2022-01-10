using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mhl.String
{
	/// <summary>
	/// 空文字列をチェックする
	/// </summary>
	public class CheckStringEmpty
	{
		/// <summary>
		/// 空文字列か
		/// </summary>
		/// <param name="str">チェックする文字列</param>
		/// <returns>空文字列もしくはnullならtrue そうでなければfalse</returns>
		public bool IsEmpty(string str)
		{
			return System.String.IsNullOrEmpty(str);
		}
	}
}
