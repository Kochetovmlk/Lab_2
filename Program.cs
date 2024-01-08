using System;

// Базовый класс для учеников
class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Ученик учится");
    }

    public virtual void Read()
    {
        Console.WriteLine("Ученик читает");
    }

    public virtual void Write()
    {
        Console.WriteLine("Ученик пишет");
    }

    public virtual void Relax()
    {
        Console.WriteLine("Ученик отдыхает");
    }
}

// Производный класс для отличника
class ExcellentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Отличник учится отлично");
    }
}

// Производный класс для хорошего ученика
class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Хороший ученик учится хорошо");
    }
}

// Производный класс для слабого ученика
class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Слабый ученик учится плохо");
    }
}

// Класс, представляющий учебный класс
class ClassRoom
{
    private Pupil[] pupils;

    public ClassRoom(params Pupil[] pupils)
    {
        if (pupils.Length < 2 || pupils.Length > 3)
        {
            throw new ArgumentException("Класс должен состоять из 2 или 3 учеников.");
        }

        this.pupils = pupils;
    }

    public void DoStudy()
    {
        foreach (Pupil pupil in pupils)
        {
            pupil.Study();
        }
    }

    public void DoRead()
    {
        foreach (Pupil pupil in pupils)
        {
            pupil.Read();
        }
    }

    public void DoWrite()
    {
        foreach (Pupil pupil in pupils)
        {
            pupil.Write();
        }
    }

    public void DoRelax()
    {
        foreach (Pupil pupil in pupils)
        {
            pupil.Relax();
        }
    }
}

class Program
{
    static void Main()
    {
        Pupil pupil1 = new ExcellentPupil();
        Pupil pupil2 = new GoodPupil();
        Pupil pupil3 = new BadPupil();

        ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3);

        Console.WriteLine("Уроки в классе:");
        classRoom.DoStudy();
        Console.WriteLine("\nЧтение в классе:");
        classRoom.DoRead();
        Console.WriteLine("\nПисьмо в классе:");
        classRoom.DoWrite();
        Console.WriteLine("\nПерерыв в классе:");
        classRoom.DoRelax();
    }
}