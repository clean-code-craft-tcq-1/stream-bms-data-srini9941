package bms.stream.sender.value.printer;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-06-04
 */
class ValuePrinterFactoryTest {

    @Test
    void getValuePrinterFor_forConsole() {
        // ARRANGE
        ValuePrinterFactory valuePrinterFactory = new ValuePrinterFactory();

        // ACT
        ValuePrinter valuePrinter = valuePrinterFactory.getValuePrinterFor("console");

        // ASSERT
        assertTrue(valuePrinter instanceof ConsoleValuePrinter);

    }

    @Test
    void getValuePrinterFor_forNull() {
        // ARRANGE
        ValuePrinterFactory valuePrinterFactory = new ValuePrinterFactory();

        // ACT
        ValuePrinter valuePrinter = valuePrinterFactory.getValuePrinterFor("other");

        // ASSERT
        assertNull(valuePrinter);

    }
}