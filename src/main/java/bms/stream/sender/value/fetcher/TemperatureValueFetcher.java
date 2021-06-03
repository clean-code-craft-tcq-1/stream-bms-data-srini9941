package bms.stream.sender.value.fetcher;

import bms.stream.sender.util.Utilities;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-06-01
 */
public class TemperatureValueFetcher implements ValueFetcher {

    private static final double MIN = 0;
    private static final double MAX = 40;

    @Override
    public double fetch() {
        return Utilities.generateRandomValue(MIN, MAX);
    }
}
