package bms.stream.sender.value.fetcher;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-06-04
 */
class ValueFetcherFactoryTest {

    @Test
    void testGetValueFetcherFor_forTemperature() {
        // ARRANGE
        ValueFetcherFactory valueFetcherFactory = new ValueFetcherFactory();

        // ACT
        ValueFetcher valueFetcher = valueFetcherFactory.getValueFetcherFor("temperature");

        // ASSERT
        assertTrue(valueFetcher instanceof TemperatureValueFetcher);

    }

    @Test
    void testGetValueFetcherFor_forSoc() {
        // ARRANGE
        ValueFetcherFactory valueFetcherFactory = new ValueFetcherFactory();

        // ACT
        ValueFetcher valueFetcher = valueFetcherFactory.getValueFetcherFor("soc");

        // ASSERT
        assertTrue(valueFetcher instanceof SOCValueFetcher);

    }

    @Test
    void testGetValueFetcherFor_forNull() {
        // ARRANGE
        ValueFetcherFactory valueFetcherFactory = new ValueFetcherFactory();

        // ACT
        ValueFetcher valueFetcher = valueFetcherFactory.getValueFetcherFor("other");

        // ASSERT
        assertNull(valueFetcher);

    }
}