namespace BlazorMem;

public class MemTest
{
    private byte[]? _memBuffer = null;

    public void AllocateMemory()
    {
        _memBuffer = new byte[512 * 1024 * 1024];
    }

    public void FreeMemory()
    {
        _memBuffer = null;
        //GC.Collect(); // This is not recommended, and it has no effect in this case
    }
}