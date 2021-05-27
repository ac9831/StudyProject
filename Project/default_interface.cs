using System;

interface ICamera
{
    void takePicture();

    void uploadSNS()
    {
        Console.WriteLine("upload SNS");
    }
}

class Camera : ICamera
{
    public void takePicture()
    {
        Console.WriteLine("Take Picture With Camera");
    }
}

class Program
{
    static void Main()
    {
        Camera c = new Camera();
        c.takePicture();

        ICamera ic = c;
        ic.uploadSNS();
    }
}