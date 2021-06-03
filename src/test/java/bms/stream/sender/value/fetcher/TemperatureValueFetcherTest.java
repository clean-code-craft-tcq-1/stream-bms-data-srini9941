package bms.stream.sender.value.fetcher;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-06-01
 */
class TemperatureValueFetcherTest {


    private ValueFetcher fetcher;

    @Test
    public void testFetch_success() {
        double min = 0;
        double max = 40;
        fetcher = new TemperatureValueFetcher();

        double value = fetcher.fetch();

        assertTrue(value >= min && value <= max);
    }

}
