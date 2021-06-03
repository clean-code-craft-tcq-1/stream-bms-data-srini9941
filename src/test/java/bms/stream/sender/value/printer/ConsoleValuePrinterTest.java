package bms.stream.sender.value.printer;

import java.io.ByteArrayOutputStream;
import java.io.PrintStream;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-06-04
 */
public class ConsoleValuePrinterTest {

    private final PrintStream standardOut = System.out;
    private final ByteArrayOutputStream outputStreamCaptor = new ByteArrayOutputStream();

    @BeforeEach
    public void setup() {
        System.setOut(new PrintStream(outputStreamCaptor));
    }

    @Test
    void testPrint() {
        // ARRANGE
        String testString = "This is a test string";
        ValuePrinter valuePrinter =  new ConsoleValuePrinter();

        // ACT
        valuePrinter.print(testString);

        // ASSERT
        assertEquals(testString, outputStreamCaptor.toString().trim());

    }

}
