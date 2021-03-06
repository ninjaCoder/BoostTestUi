﻿//  (C) Copyright Gert-Jan de Vos 2012.
//  Distributed under the Boost Software License, Version 1.0.
//  (See accompanying file LICENSE_1_0.txt or copy at 
//  http://www.boost.org/LICENSE_1_0.txt)

//  See http://boosttestui.wordpress.com/ for the boosttestui home page.

namespace NUnit.Framework
{
	public static class TestFixtureAttribute { }
	public static class CategoryAttribute { }
	public static class ExplicitAttribute { }
	public static class ExpectedExceptionAttribute { }
	public static class TestAttribute { }
	public static class SequentialAttribute { }
	public static class ParameterDataAttribute { }
	public static class ValuesAttribute { }
	public static class IgnoreAttribute { }
	public static class TestFixtureSetUpAttribute { }
	public static class SetUpAttribute { }
	public static class TearDownAttribute { }
	public static class TestFixtureTearDownAttribute { }
	public static class RepeatAttribute { }
	public static class SuccessException { }
	public static class IgnoreException { }
    public static class TestCaseAttribute { }
    public static class TestCaseSourceAttribute { }

    public class NoExpectedException : System.Exception
	{
		public NoExpectedException(string message)
			: base(message)
		{
		}
	}
}
