package bms.stream.sender.value.printer;

import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.Stream;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-06-04
 */
public class ValuePrinterFactory {

    List<ValuePrinter> valuePrinters = Stream.of(
        new ConsoleValuePrinter()
    ).collect(Collectors.toList());

    public ValuePrinter getValuePrinterFor(String printerName) {
        return valuePrinters.stream()
            .filter(i -> i.getClass().getName().toLowerCase().contains(printerName))
            .findFirst()
            .orElse(null);
    }

}
