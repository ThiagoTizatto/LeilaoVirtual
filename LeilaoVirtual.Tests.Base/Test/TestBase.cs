using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Tests.Base.Test
{
    [TestFixture]
    public abstract class TestBase
    { 
        [SetUp]
        public abstract void Initialize();
    }
}
