# car park simulator
 IRSM Group Project
Liam Hill, joe leach, joe guz
-----------------------------

c++ version of simulator for webpages

# building with emscriptem
## debug
```
emcc coin.cpp -o coin.bc -g4
emcc EntryBarrier.cpp -o EntryBarrier.bc -g4
emcc ExitBarrier.cpp -o ExitBarrier.bc -g4
emcc FullSign.cpp -o FullSign.bc -g4
emcc carpark.cpp -o carpark.bc -g4
emcc payment.cpp -o payment.bc -g4
emcc coinmachine.cpp -o coinmachine.bc -g4
emcc carweb.cpp -o carweb.bc -g4
emcc coin.bc EntryBarrier.bc ExitBarrier.bc FullSign.bc carpark.bc payment.bc coinmachine.bc carweb.bc -o carweb.js -g4
```
## release
```
emcc coin.cpp -o coin.bc -O3 --js-opts 1 --closure 2
emcc EntryBarrier.cpp -o EntryBarrier.bc -O3 --js-opts 1 --closure 2
emcc ExitBarrier.cpp -o ExitBarrier.bc -O3 --js-opts 1 --closure 2
emcc FullSign.cpp -o FullSign.bc -O3 --js-opts 1 --closure 2
emcc carpark.cpp -o carpark.bc -O3 --js-opts 1 --closure 2
emcc payment.cpp -o payment.bc -O3 --js-opts 1 --closure 2
emcc coinmachine.cpp -o coinmachine.bc -O3 --js-opts 1 --closure 2
emcc carweb.cpp -o carweb.bc -O3 --js-opts 1 --closure 2
emcc coin.bc EntryBarrier.bc ExitBarrier.bc FullSign.bc carpark.bc payment.bc coinmachine.bc carweb.bc -o carweb.js -O3 --js-opts 1 --closure 2
```

