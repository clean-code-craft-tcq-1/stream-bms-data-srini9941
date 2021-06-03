package bms.stream.sender.value.fetcher;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-06-01
 */
class SOCValueFetcherTest {


    private ValueFetcher fetcher;

    @Test
    public void testFetch_success() {
        // ARRANGE
        double min = 10;
        double max = 90;
        fetcher = new SOCValueFetcher();

        // ACT
        double value = fetcher.fetch();

        // ASSERT
        assertTrue(value >= min && value <= max);
    }

}
