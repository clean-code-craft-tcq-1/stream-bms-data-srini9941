package bms.stream.sender.util;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

/**
 *
 * @author Shrinidhi Muralidhar Karanam on 2021-06-01
 */
class UtilitiesTest {

    @Test
    public void testRandomNumberGenerator(){
        double min = 0;
        double max = 10;
        double value = Utilities.generateRandomValue(min, max);

        assertTrue(value > min && value < max);
    }

}
