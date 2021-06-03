package bms.stream.sender.value.printer;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-06-04
 */
public class ConsoleValuePrinter implements ValuePrinter {

    @Override
    public void print(String value) {
        System.out.println(value);
    }
}
