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
emcc carweb.cpp -o carweb.bc -g4 -s EXPORTED_FUNCTIONS="['_main', '_btnCarArrives_Click()', '_btnPressForCoin_Click()', '_btnEnterCarPark_Click()','_btnCarArrivesAtExit_Click()','_btnEnterCoin_Click()','_btnExitCarPark_Click()','_btnInsertCoin_Click()','_btnInsert1Pound_Click()','_btnInsert5p_Click()','_btnInsert10p_Click()','_btnCalculateValue_Click()','_btnRequestCoin_Click()','_btnInsert20p_Click()','_btnInsert1p_Click()','_btnInsert2p_Click()','_btnInsert50p_Click()','_btnInsert2Pound_Click()']" --js-library utilitys.js
emcc coin.bc EntryBarrier.bc ExitBarrier.bc FullSign.bc carpark.bc payment.bc coinmachine.bc carweb.bc -o carweb.js -g4 --js-library utilitys.js
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
emcc carweb.cpp -o carweb.bc -O3 --js-opts 1 --closure 2 -s EXPORTED_FUNCTIONS="['_main', '_btnCarArrives_Click()', '_btnPressForCoin_Click()', '_btnEnterCarPark_Click()','_btnCarArrivesAtExit_Click()','_btnEnterCoin_Click()','_btnExitCarPark_Click()','_btnInsertCoin_Click()','_btnInsert1Pound_Click()','_btnInsert5p_Click()','_btnInsert10p_Click()','_btnCalculateValue_Click()','_btnRequestCoin_Click()','_btnInsert20p_Click()','_btnInsert1p_Click()','_btnInsert2p_Click()','_btnInsert50p_Click()','_btnInsert2Pound_Click()']"
emcc coin.bc EntryBarrier.bc ExitBarrier.bc FullSign.bc carpark.bc payment.bc coinmachine.bc carweb.bc -o carweb.js -O3 --js-opts 1 --closure 2
```

