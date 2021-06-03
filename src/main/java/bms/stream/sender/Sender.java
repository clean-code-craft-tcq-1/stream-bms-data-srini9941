package bms.stream.sender;

import java.util.Iterator;
import java.util.List;
import java.util.Timer;
import java.util.TimerTask;
import java.util.stream.Collectors;
import java.util.stream.Stream;

import bms.stream.sender.value.fetcher.ValueFetcher;
import bms.stream.sender.value.fetcher.ValueFetcherFactory;
import bms.stream.sender.value.printer.ValuePrinterFactory;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-06-04
 */
public class Sender {

    private static final List<String> PARAMETER_LIST = Stream.of("temperature", "soc").collect(Collectors.toList());
    private static final String PRINTER_TYPE = "console";

    private static final ValueFetcherFactory FETCHER_FACTORY = new ValueFetcherFactory();
    private static final ValuePrinterFactory PRINTER_FACTORY = new ValuePrinterFactory();

    public static void main(String[] args) {
        Timer timer = new Timer();
        timer.schedule(new TimerTask() {
            @Override
            public void run() {
                streamData();
            }
        }, 0, 1000);
    }

    private static void streamData() {
        BatteryData batteryData = new BatteryData(Double.NaN, Double.NaN);
        Iterator<String> iterator = PARAMETER_LIST.iterator();
        while (iterator.hasNext()) {
            batteryData = new BatteryData(
                FETCHER_FACTORY.getValueFetcherFor(iterator.next()).fetch(),
                FETCHER_FACTORY.getValueFetcherFor(iterator.next()).fetch()
            );
        }
        PRINTER_FACTORY.getValuePrinterFor(PRINTER_TYPE).print(batteryData.toString());
    }

}
