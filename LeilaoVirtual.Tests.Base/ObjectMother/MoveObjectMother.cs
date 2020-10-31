using LeilaoVirtual.Domain.Features.Moves;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Tests.Base.ObjectMother
{
    public static class MoveObjectMother
    {
        public static Move Default
        {
            get
            {
                var move = new Move()
                {
                    MoveValue = 100,
                    Person = PersonObjectMother.Defaut
                };

                return move;
            }
        }

        public static Move Default2
        {
            get
            {
                var move = new Move()
                {
                    MoveValue = 200,
                    Person = PersonObjectMother.Defaut2
                };

                return move;
            }
        }

        public static Move Default3
        {
            get
            {
                var move = new Move()
                {
                    MoveValue = 300,
                    Person = PersonObjectMother.Defaut3
                };

                return move;
            }
        }

        public static Move InvalidPerson
        {
            get
            {
                var move = new Move()
                {
                    MoveValue = 100,
                };

                return move;
            }
        }
        public static Move InvalidMoveValue
        {
            get
            {
                var move = new Move()
                {
                    MoveValue = 0,
                    Person = PersonObjectMother.Defaut
                };

                return move;
            }
        }



    }
}
