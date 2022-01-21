namespace BlazorMem;

public class MemTest
{
    private byte[]? _memBuffer = null;

    public void AllocateMemory()
    {
        _memBuffer = new byte[512 * 1024 * 1024];
    }

    public void FreeMemory(bool runGc)
    {
        _memBuffer = null;

        if (runGc)
        {
            GC.Collect();
        }
    }
}