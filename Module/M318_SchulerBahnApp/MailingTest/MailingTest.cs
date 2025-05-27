using System;
using SwissTransport.Core;
using SwissTransport.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace MailingTest

{
    public class MailingTest
    {
        [Fact]
        public void StringProof()
        {
            // arrange
            Mailing testee = new Mailing("Brunnen", "Luzern", "test1", "test2", "test3");
            var expectedresult = "mailto:mail@domain.com?subject=Informationen für die Verbindung&body=Abfahrtsort =Brunnen \n Ankunftsort =Luzern \n Dauer =test1 \n Gleis =test2\n Verspätung =test3";

            //Act
            var result = testee.Url;

            // assert
            result.Should().Be(expectedresult);
        }
    }
}