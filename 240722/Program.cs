namespace 박종요_과제1._chracter_클래스_선언하기
{
    internal class Program
    {    //과제 1.Chracter 클래스 선언하기
            //Chracter 클래스를 선언하고, 클래스가 가져야 할 필드와 메서드는 아래와 같다.
        class Character()
        {   
            //*필드
            //레벨
            //체력
            //이동 속도
            //공격력

            public int level;
            public int hp;
            public float speed;
            public int attackPower;
            //*메서드
            //전진 = MoveFoward
            public void MoveFoward() { }
            
            //후진 = MoveBackward
            public void MoveBackward() { }
            
            //좌회전(90도) = TurnLeft
            public void TurnLeft() { }

            //우회전(90도) = TurnRight
            public void TurnRight() { }
            
            //공격 = Attack
            public void Attack() { }   

            //피격 = TakeDamage
            public void TakeDamage() { }


        }
        static void Main(string[] args)
        {
        
            //과제의 의미와 필드,메서드의 뜻을 잘 이해하지 못한것같습니다.
            
        }
    }
}
