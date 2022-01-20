
let array = [];

export function allocateArray() {
    array = new Uint8Array(1024 * 1024 * 1024);
    array.fill(128);
}

export function freeArray() {
    array = [];
}

export function getMemUsage() {
    return performance.memory.usedJSHeapSize;
}
