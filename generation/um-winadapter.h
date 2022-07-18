//#include "local.dxc.h"
//#include <Winerror.h>
// #include <stdint.h>
//
// typedef uint32_t DWORD;   // DWORD = unsigned 32 bit value
// typedef uint16_t WORD;    // WORD = unsigned 16 bit value
// typedef uint8_t BYTE;     // BYTE = unsigned 8 bit value

typedef unsigned short WORD;
typedef unsigned char BYTE;
typedef unsigned long DWORD;

typedef int HRESULT;

typedef struct _GUID {
    DWORD Data1;
    WORD  Data2;
    WORD  Data3;
    BYTE  Data4[8];
} GUID;

typedef unsigned long ULONG;

typedef GUID CLSID;
typedef const GUID &REFGUID;
typedef const GUID &REFCLSID;

typedef GUID IID;
typedef IID *LPIID;
typedef const IID &REFIID;

#ifndef CROSS_PLATFORM_UUIDOF
// Warning: This macro exists in dxcapi.h as well
#define CROSS_PLATFORM_UUIDOF(interface, spec)                                 \
struct __declspec(uuid(spec)) interface;
#endif

CROSS_PLATFORM_UUIDOF(IUnknown, "00000000-0000-0000-C000-000000000046")
struct IUnknown {
    //IUnknown() : m_count(0) {};
    virtual HRESULT QueryInterface(REFIID riid, void **ppvObject) = 0;
    virtual ULONG AddRef();
    virtual ULONG Release();
    virtual ~IUnknown();
    template <class Q> HRESULT QueryInterface(Q **pp) {
        return QueryInterface(__uuidof(Q), (void **)pp);
    }

// private:
//     std::atomic<unsigned long> m_count;
};

CROSS_PLATFORM_UUIDOF(IMalloc, "00000002-0000-0000-C000-000000000046")
struct IMalloc : public IUnknown {
    virtual void *Alloc(size_t size);
    virtual void *Realloc(void *ptr, size_t size);
    virtual void Free(void *ptr);
    virtual HRESULT QueryInterface(REFIID riid, void **ppvObject);
};

//#include "F:\DirectXShaderCompiler-main\include\dxc\Support\WinAdapter.h"
